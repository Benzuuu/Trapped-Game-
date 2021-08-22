using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour
{
    [Header("Detection Parameter(s)")]
    public Transform detectionPoint;
    private const float detectionRadius = 0.2f;
    public LayerMask detectionLayer;
    public GameObject detectedObject;

    [Header("Examine Parameter(s)")]
    public GameObject examineWindow;
    public Image examineImage;
    public Text examineText;
    
    [Header("Note Interaction")]
    public GameObject noteWindow;
    public Text noteText;

    public GameObject hint;
    private float delayinSeconds = 3;
    
    
    void Start()
    {
        //pl = GetComponent<Player>();
    }

    void Update()
    {
        if(DetectObject())
        {
            hint.SetActive(true);
            if (InteractInput())
            {
                detectedObject.GetComponent<Item>().Interact();
            }
        }
        else
            hint.SetActive(false);
        
        //Examine Window
        if (examineWindow.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            examineWindow.SetActive(false);
        }
        else if(examineWindow.activeSelf)
        {
            if (delayinSeconds > 0)
                delayinSeconds -= Time.deltaTime;
 
            if (delayinSeconds == 0 || delayinSeconds < 0)
            {
                examineWindow.SetActive(false);
                delayinSeconds = 3;
            }
        }

        //Note Window
        if (noteWindow.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            noteWindow.SetActive(false);
        }
        else if (noteWindow.activeSelf)
        {
            if (delayinSeconds > 0)
                delayinSeconds -= Time.deltaTime;

            if (delayinSeconds == 0 || delayinSeconds < 0)
            {
                noteWindow.SetActive(false);
                delayinSeconds = 3;
            }
        }
    }

    bool InteractInput()
    {
        return Input.GetKeyDown(KeyCode.E);
    }

    bool DetectObject()
    {
        Collider2D obj = Physics2D.OverlapCircle(detectionPoint.position, detectionRadius, detectionLayer);
        if(obj == null)
        {
            //detectedObject = null;
            return false;
        }
        else
        {
            detectedObject = obj.gameObject;
            return true;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(detectionPoint.position, detectionRadius);
    }

    public void PickUpItem(GameObject item)
    {
        Manager.instance.AddToInventory(item);
    }

    public void ExamineItem(Item item)
    {
        examineImage.sprite = item.GetComponent<SpriteRenderer>().sprite;
        examineText.text = item.descText;
        examineWindow.SetActive(true);
    }

    public void OpenNote(Item item)
    {
        noteText.text = item.descText;
        noteWindow.SetActive(true);
    }

    /*
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2);
    }
    */
}
