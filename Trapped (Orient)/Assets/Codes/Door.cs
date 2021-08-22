using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]

public class Door : MonoBehaviour
{
    public enum InteractionType{ None, Door1}
    public InteractionType type;

    public GameObject door1;

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
            case InteractionType.Door1:
                GameObject door = gameObject;
                gameObject.SetActive(false);
                break;

            default:
                Debug.Log("No Assigned Type");
                break;
        }
        customEvent.Invoke();
    }
}
