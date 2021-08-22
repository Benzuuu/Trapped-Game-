using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemHolders : MonoBehaviour
{
    private List<GameObject> holders;
    private List<GameObject> selects;

    private int startIndex;

    public GameObject selectedObjectDisplays;

    void Start()
    {
        holders = new List<GameObject>();
        selects = new List<GameObject>();

        //Retrieve all 3 item holders
        foreach (Transform t in transform)
        {
            holders.Add(t.gameObject);
        }

        //Retrieve all 3 select images
        foreach (GameObject g in holders)
        {
            selects.Add(g.transform.GetChild(1).gameObject);
        }
    }

    //Populate the holders, 3 items at a time
    public void PopHolders(int multiplier)
    {
        startIndex = 3 * multiplier;

        for (int holderIndex = 0, playerIndex = startIndex; playerIndex < Manager.instance.playerInventory.Count && holderIndex < 3; holderIndex++, playerIndex++)
        {
            holders[holderIndex].transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Manager.instance.playerInventory[playerIndex].GetComponent<SpriteRenderer>().sprite;
        }
    }

    //Method to reset the contents of the item holders
    public void ResetHolders()
    {
        foreach (GameObject g in holders)
        {
            g.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = null;
        }
    }

    //Method to show holders with content and hide holders without content
    public void ToggleHolders()
    {
        foreach(GameObject g in holders)
        {
            if (g.transform.GetChild(0).gameObject.GetComponent<Image>().sprite != null)
            {
                g.SetActive(true);
            } 
            else
            {
                g.SetActive(false);
            }
        }
    }

    //Toggle select images in the holders, displays selected object's name and enlarged icon
    public void ToggleSelects(int current)
    {
        if (Manager.instance.playerInventory.Count > 0)
        {

            if (!selectedObjectDisplays.activeSelf)
            {
                selectedObjectDisplays.SetActive(true);
            }

            for (int i = 0; i < selects.Count; i++)
            {
                if (i == current)
                {
                    selects[i].SetActive(true);
                    selectedObjectDisplays.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = Manager.instance.playerInventory[startIndex + i].GetComponent<SpriteRenderer>().sprite;
                    selectedObjectDisplays.transform.GetChild(1).gameObject.GetComponent<Text>().text = Manager.instance.playerInventory[startIndex + i].GetComponent<Item>().descText;
                }
                else
                {
                    selects[i].SetActive(false);
                }
            }
        }
    }
}