using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlyGame : MonoBehaviour
{
    public GameObject MainCam;
    public GameObject FlyCam;
    public GameObject FlyNet;
    public bool FlyStart;
    public bool flyMoving;

    // Start is called before the first frame update
    void Start()
    {
        FlyStart = false;
        flyMoving = false;
    }

    private void Update()
    {
        if (FlyStart == true)
        {
            if (Input.GetKeyDown("e"))
            {
                MainCam.SetActive(false);
                FlyCam.SetActive(true);
                FlyNet.SetActive(true);
                flyMoving = true;
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
