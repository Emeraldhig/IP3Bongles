using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JarOfFlies : MonoBehaviour, IInventoryItem
{
    public string Name
    {
        get
        {
            return "Jar Of Flies";
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
