using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class KeyPickUp : MonoBehaviour
{
    // Start is called before the first frame update
    public static int KeyValue;
    public int InternalKey;
    public GameObject Key1;
    // Update is called once per frame
    void Update()
    {
        InternalKey = KeyValue;

        if(KeyValue >= 1)
        {
            Key1.SetActive(true);
        }
        
    }
}
