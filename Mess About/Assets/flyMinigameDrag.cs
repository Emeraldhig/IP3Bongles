using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyMinigameDrag : MonoBehaviour
{
    public bool flyMinigame = false;
    public Inventory inventory;

    public void OnTriggerEnter(Collider other)
    {
        if (inventory.Check("Bug Net"))
        {
            flyMinigame = true;
        }
    }
}
