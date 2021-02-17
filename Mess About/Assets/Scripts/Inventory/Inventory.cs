using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    private const int SLOTS = 9;

    private List<IInventoryItem> mItems = new List<IInventoryItem>();

    public event EventHandler<InventoryEventArgs> ItemAdded;

    public void AddItem(IInventoryItem item)
    {
        if(mItems.Count < SLOTS)
        {
            Collider collider = (item as MonoBehaviour).GetComponent<Collider>();
            if (collider.enabled)
            {
                collider.enabled = false;

                mItems.Add(item);

                item.OnPickup();

                ItemAdded?.Invoke(this, new InventoryEventArgs(item));
            }
        }
    }

    public List<IInventoryItem> GetItems()
    {
        return mItems;
    }

    public bool Check(string targetItem)
    {
        for (int i = 0; i < mItems.Count; i++)
        {
            if (mItems[i].Name == targetItem)
            {
                return true;
            }
        }
        return false;
    }

    public void Remove(string targetItem)
    {
        for (int i = 0; i < mItems.Count; i++)
        {
            if (mItems[i].Name == targetItem)
            {
                mItems.RemoveAt(i);
                return;
            }
        }
    }
}
