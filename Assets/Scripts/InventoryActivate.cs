using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryActivate : MonoBehaviour
{
    [SerializeField]
    private GameObject inventory;

    [SerializeField]
    private GameObject[] objects;

    private bool objectCollected;

    [SerializeField]
    private bool test;
    public void Update()
    {
        objectCollected = objects[0].GetComponent<DragObject>().getObjectUse();
        test = true;
        Instantiate(inventory);

        if (objectCollected)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                Instantiate(objects[i]);
            }
        }
    }
    
}
