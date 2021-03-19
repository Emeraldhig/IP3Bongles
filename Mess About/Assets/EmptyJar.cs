using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyJar : MonoBehaviour, IInventoryItem
{
    public GameObject jarPuzzle;

    public string Name
    {
        get
        {
            return "Empty Jar";
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
    public void OnTriggerEnter(Collider other)
    {
        jarPuzzle.SetActive(true);
    }
}
