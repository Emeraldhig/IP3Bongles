using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{

    public Inventory Inventory;
    public GameObject Craft;
    public GameObject BugNet;

    // Start is called before the first frame update
    void Start()
    {
        Inventory.ItemAdded += InventoryScript_ItemAdded;
    }

    private void Update()
    {
        if (Inventory.Check("Hoop") && Inventory.Check("Stick") && Inventory.Check("Net"))
        {
            Craft.SetActive(true);
        }
        else
        {
            Craft.SetActive(false);
        }
    }

    public void CraftNet()
    {
        Inventory.Remove("Hoop");
        Inventory.Remove("Stick");
        Inventory.Remove("Net");
        Inventory.AddItem(BugNet.GetComponent<IInventoryItem>());
        InventoryScript_ItemRemoved();
    }

    private void InventoryScript_ItemAdded(object sender, InventoryEventArgs e)
    {
        Transform inventoryPanel = transform.Find("InventoryPanel");
        foreach(Transform slot in inventoryPanel)
        {
            Image image = slot.GetChild(0).GetComponent<Image>();
            Text text = slot.GetChild(1).GetComponent<Text>();

            if (!image.enabled)
            {
                image.enabled = true;
                image.sprite = e.Item.Image;
            }
            if (!text.enabled)
            {
                text.enabled = true;
                text.text = e.Item.Name;

                break;
            }
        }
    }

    private void InventoryScript_ItemRemoved()
    {
        List<IInventoryItem> items = Inventory.GetItems();
        Transform inventoryPanel = transform.Find("InventoryPanel");
        for (int i = 0; i < inventoryPanel.childCount; i++)
        {
            Image image = inventoryPanel.GetChild(i).GetChild(0).GetComponent<Image>();
            Text text = inventoryPanel.GetChild(i).GetChild(1).GetComponent<Text>();

            if (i < items.Count)
            {
                image.enabled = true;
                image.sprite = items[i].Image;

                text.enabled = true;
                text.text = items[i].Name;
            }
            else
            {
                image.enabled = false;
                text.enabled = false;
            }
        }
    }

}
