using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyGame : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject FlyNet;
    public bool FlyStart;
    public bool flyMovement;

    // Start is called before the first frame update
    void Start()
    {
        FlyStart = false;
    }

    private void Update()
    {
        if (FlyStart == true)
        {
            if (Input.GetKeyDown("e"))
            {
                camera1.SetActive(false);
                camera2.SetActive(true);
                FlyNet.SetActive(true);
                flyMovement = true;
            }

            if (Input.GetKeyDown("f"))
            {
                camera1.SetActive(true);
                camera2.SetActive(false);
                FlyNet.SetActive(false);
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        FlyStart = true;
    }

    private void OnTriggerExit(Collider other)
    {
        FlyStart = true;
    }
}
