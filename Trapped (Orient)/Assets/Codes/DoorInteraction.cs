using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorInteraction : MonoBehaviour
{
    [Header("Detection Parameter(s)")]
    public Transform detectionPoint;
    private const float detectionRadius = 0.2f;
    public LayerMask detectionLayer;
    public GameObject detectedObject;

    [Header("Door Interaction")]
    public GameObject dialogueWindow;
    public Text dialogueText;

    private float delayinSeconds = 3;


    void Update()
    {
        if (DetectObject())
        {
            if (InteractInput())
            {
                detectedObject.GetComponent<Door>().Interact();
            }
        }

        //Dialogue Box
        if (dialogueWindow.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            dialogueWindow.SetActive(false);
        }
        else if (dialogueWindow.activeSelf)
        {
            if (delayinSeconds > 0)
                delayinSeconds -= Time.deltaTime;

            if (delayinSeconds == 0 || delayinSeconds < 0)
            {
                dialogueWindow.SetActive(false);
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
        if (obj == null)
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


    public void InteractDoor(Item item)
    {
        dialogueText.text = item.descText;
        dialogueWindow.SetActive(true);
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2);
    }

}
