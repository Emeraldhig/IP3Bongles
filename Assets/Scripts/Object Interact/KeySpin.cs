using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class KeySpin : MonoBehaviour
{

    
    [SerializeField]
    private float RotateSpeed;
    [SerializeField]
    private GameObject ThisKey;
    [SerializeField]
    private GameObject Bubba;
    [SerializeField]
    private GameObject infobox;
    [SerializeField]
    private Transform infobox_pos;
    [SerializeField]
    private GameObject pickup;
    [SerializeField]
    private Transform pickup_pos;

    public GameObject speaker_hoop;

    // Update is called once per frame
    void Update()
    {
        //RotateSpeed = 0.2f;
        transform.Rotate(0, RotateSpeed, 0, Space.World);
    }
    void OnTriggerEnter()
    {
        ThisKey.SetActive(false);
        Bubba.SetActive(true);
    }
    void OnMouseDown() 
    {
        infobox.transform.position = infobox_pos.transform.position;
        infobox.transform.localScale = new Vector3(5, 5, 1);
        Instantiate(infobox);
        pickup.transform.position = pickup_pos.transform.position;
        pickup.transform.localScale = new Vector3(3, 3, 1);
        Instantiate(pickup);
        speaker_hoop.SetActive(true);
        //       KeyPickUp.KeyValue += 1;
        //       ThisKey.SetActive(false);
        // this object was clicked - do something
    }

}
