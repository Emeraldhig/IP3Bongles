using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRotate : MonoBehaviour
{
    public float rotationSpeed = 0.3f;
    public GameObject PortcullisMaster;
    public GameObject KeyMaster;
    public GameObject bubba;
    public GameObject walktoPoint;
    public GameObject KeyTurnCam;
    public GameObject MainCam;
    public GameObject NextCube;
    public bool arrowPressed;

    public void Update()
    {

        //Debug.Log(transform.eulerAngles.z);
        if (transform.eulerAngles.z >= 300)
        {
            NextCube.SetActive(true);
            PortcullisMaster.SetActive(false);
            bubba.SetActive(true);
            walktoPoint.SetActive(true);
            KeyMaster.SetActive(false);
            MainCam.SetActive(true);
            KeyTurnCam.SetActive(false);
        }

        if (arrowPressed)
        {
            KeyMaster.transform.Rotate(Vector3.forward, rotationSpeed);
        }
    }
    public void OnMouseOver()
    {
        arrowPressed = true;
    }
    public void OnMouseExit()
    {
        arrowPressed = false;
    }

}



