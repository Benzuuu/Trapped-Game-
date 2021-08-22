using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]

public class Item : MonoBehaviour
{
    public enum InteractionType{ None, PickUp, Examine, Note}
    public InteractionType type;
    public string descText;

    [Header("*For Examine Only")]
    public Sprite itemImage;

    public UnityEvent customEvent;

    private void Reset()
    {
        GetComponent<Collider2D>().isTrigger = true;

        //Item Layer Num
        gameObject.layer = 10;
    }
    public void Interact()
    {
        switch(type)
        {
            case InteractionType.PickUp:
                GameObject item = gameObject;
                FindObjectOfType<Interaction>().PickUpItem(gameObject);
                gameObject.SetActive(false);
                break;
            case InteractionType.Examine:
                FindObjectOfType<Interaction>().ExamineItem(this);
                break;
            case InteractionType.Note:
                FindObjectOfType<Interaction>().OpenNote(this);
                FindObjectOfType<Interaction>().PickUpItem(gameObject);
                gameObject.SetActive(false);
                break;
            default:
                Debug.Log("No Assigned Type");
                break;
        }
        customEvent.Invoke();
    }
}
