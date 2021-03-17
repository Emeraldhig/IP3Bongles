using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JigsawSlot : MonoBehaviour
{
    public GameObject slot;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == slot.tag && other.gameObject.transform.rotation.z == 0)
        {
            other.transform.position = slot.transform.position;
            Debug.Log("slot:" + slot.tag + " filled");
            other.GetComponent<pieceMovement>().locked = true;
        }
    }
   
}
