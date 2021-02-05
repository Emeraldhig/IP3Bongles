using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{

    public Inventory Inventory;

    // Start is called before the first frame update
    void Start()
    {
        Inventory.ItemAdded += InventoryScript_ItemAdded;
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
            print("hello");
            if (!text.enabled)
            {
                print("hello");
                text.enabled = true;
                text.text = e.Item.Name;

                break;
            }
        }
    }
}
