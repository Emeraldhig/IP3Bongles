using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRotate : MonoBehaviour
{
    public float rotationSpeed = 1f;
    public GameObject camera1;
    public GameObject camera2;
    public GameObject Gate;
    public Mesh OpenGate;
    public GameObject RotateKeyMaster;

    private void Update()
    {

        Debug.Log(transform.eulerAngles.z);
        if (transform.eulerAngles.z >= 300)
        {
            Gate.GetComponent<MeshFilter>().sharedMesh = OpenGate;
            camera1.SetActive(false);
            RotateKeyMaster.SetActive(false);
            camera2.SetActive(true);
        }
    }


    private void OnMouseDrag()
    {
        transform.Rotate(Vector3.forward, rotationSpeed);
    }
}
