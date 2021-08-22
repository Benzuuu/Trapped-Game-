using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Manager : MonoBehaviour
{
    /*
     * Script requirements:
     *  -Must be attached to an empty object
     */

    public static Manager instance;

    [Header("Checkpoint implementation")]
    private GameObject player;
    public Vector2 playerPosition;
    public Vector2 playerSpawn;

    [Header("Death transition implementation")]
    public GameObject transitionCanvas;
    private Animator transitionAnim;

    //Shake implementation
    private GameObject cam;

    [Header("Inventory implementation")]
    public GameObject inventoryCanvas;
    private Movement playerMovement;
    private Animator inventoryAnim;
    private PlayerInput playerActions;
    public List<GameObject> playerInventory;        //Public for external script access (e.g., ItemHolders.cs)
    public ItemHolders itemHolders;
    private int currentSelection;

    [Header("Despawn broadcasting")]
    public EnemyIndicator eIndicate;
    private GameObject[] forRemoval;

    //Check if instance is the same instance throughout as soon as the scene is loaded (runs before Start())
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        transitionAnim = transitionCanvas.GetComponent<Animator>();

        cam = GameObject.FindGameObjectWithTag("MainCamera");

        playerInventory = new List<GameObject>();
        playerActions = player.GetComponent<PlayerInput>();
        inventoryAnim = inventoryCanvas.GetComponent<Animator>();
        currentSelection = 0;
    }

    void Update()
    {
        //Continuously reference the player's current position
        playerPosition = player.transform.position;
    }

    public void RespawnProc()
    {
        StartCoroutine(RespawnCor());
    }

    /*
     * Note: Enemy indicator script has references to existing Game objects which are despawned by this script
     *       and as such, references are cleared by "eIndicate" before destroy methods are called. Could use
     *       improvements.
     */
    private IEnumerator RespawnCor()
    {
        transitionAnim.Play("Fade in");
        yield return new WaitForSeconds(transitionAnim.GetCurrentAnimatorStateInfo(0).length);

        //Repositions player to previous spawn; default is starting position
        player.transform.position = playerSpawn;

        //Possible error source: Object with "Enemy" tag has no "EnemyAI" script or child classes of thereof
        forRemoval = GameObject.FindGameObjectsWithTag("Enemy");
        eIndicate.clearReferences(forRemoval);
        foreach (GameObject e in forRemoval)
        {
            e.GetComponent<EnemyAI>().Despawn();
        }

        //Arbitrary set time, to smooth out the transition
        yield return new WaitForSeconds(0.5f);

        transitionAnim.Play("Fade out");
        yield return new WaitForSeconds(transitionAnim.GetCurrentAnimatorStateInfo(0).length);
    }

    //Camera must have an animator component with the "Shake" animation controller as the controller
    public void SpawnProc()
    {
        cam.GetComponent<Animator>().Play("Shake");
    }

    public void DespawnProc()
    {
        cam.GetComponent<Animator>().Play("Shake");

        //Possible error source: Object with "Enemy" tag has no "EnemyAI" script or child classes of thereof
        forRemoval = GameObject.FindGameObjectsWithTag("Enemy");
        eIndicate.clearReferences(forRemoval);
        foreach (GameObject e in forRemoval)
        {
            e.GetComponent<EnemyAI>().Despawn();
        }
    }

    //Adds item to inventory
    public void AddToInventory(GameObject g)
    {
        playerInventory.Add(g);
    }

    //Toggle the inventory
    public void ToggleInventory(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            LoadInventory();
            StartCoroutine(InventoryCor());
        }
    }

    private IEnumerator InventoryCor()
    {
        //Swap action maps interchangeably, fixed strings could use some work
        if (playerActions.currentActionMap.name == "General")
        {

            //Play show inventory animation and wait for animation to finish before changing action maps
            itemHolders.ToggleSelects(currentSelection);
            inventoryAnim.Play("Show inventory");
            yield return new WaitForSeconds(inventoryAnim.GetCurrentAnimatorStateInfo(0).length);
            playerActions.SwitchCurrentActionMap("Inventory");

            //Necessary to stop the player when action maps are swapped
            player.GetComponent<Movement>().StopPlayer();
        }
        else if (playerActions.currentActionMap.name == "Inventory")
        {
            //Immediately swap the action map from inventory to general so player can move immediately
            playerActions.SwitchCurrentActionMap("General");
            inventoryAnim.Play("Hide inventory");
            currentSelection = 0;
            yield return new WaitForSeconds(inventoryAnim.GetCurrentAnimatorStateInfo(0).length); 
        }
    }

    //Inventory loading procedures
    private void LoadInventory()
    {
        itemHolders.ResetHolders();
        itemHolders.PopHolders(0);
        itemHolders.ToggleHolders();
    }

    //Handle visuals for currently selected item
    public void OnSelectUp(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (currentSelection >= 0 && currentSelection < 3)
            {
                currentSelection -= 1;
            }
        }

        itemHolders.ToggleSelects(currentSelection);
    }

    public void OnSelectDown(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (currentSelection >= 0 && currentSelection < 3)
            {
                currentSelection += 1;
            }
        }

        itemHolders.ToggleSelects(currentSelection);
    }
}
