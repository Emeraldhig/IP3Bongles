using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour, IInventoryItem
{

    public string Name
    {
        get
        {
            return "Brainy's Book";
        }
    }

    public Sprite _Image = null;

    public Sprite Image
    {
        get
        {
            return _Image;
        }
    }

    public void OnPickup()
    {
        gameObject.SetActive(false);
    }

}
