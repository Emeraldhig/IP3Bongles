using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowTurn : MonoBehaviour
{
    public GameObject key;
    

    private void OnMouseEnter()
    {
        
       key.GetComponent<KeyRotate>().arrowPressed = true;
        

    }
    private void OnMouseExit()
    {
        key.GetComponent<KeyRotate>().arrowPressed = false;

    }
   
}
