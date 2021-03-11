using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRotate : MonoBehaviour
{
    public float rotationSpeed = 1f;
    public GameObject PortcullisMaster;
    public GameObject KeyMaster;
    public GameObject KeyTurnCam;
    public GameObject MainCam;
    public bool arrowPressed;

    private void Update()
    {

        Debug.Log(transform.eulerAngles.z);
        if (transform.eulerAngles.z >= 300)
        {
            PortcullisMaster.SetActive(false);
            KeyMaster.SetActive(false);
            MainCam.SetActive(true);
            KeyTurnCam.SetActive(false);
        }

        if (arrowPressed)
        {
            transform.Rotate(Vector3.forward, rotationSpeed);
        }
    }
}


  
