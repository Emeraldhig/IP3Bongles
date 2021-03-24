using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{

    public bool trigger = false;
    
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bubba")
        {
            trigger = true;
        }
    }
}
