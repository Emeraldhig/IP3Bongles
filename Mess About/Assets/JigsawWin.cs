﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JigsawWin : MonoBehaviour
{
    public GameObject JarMaster;
    public GameObject CloudAnim;
    public GameObject Jar3D;
    public GameObject Jar1;
    public Vector3 Jar1pos;
    public GameObject Jar2;
    public Vector3 Jar2pos;
    public GameObject Jar3;
    public Vector3 Jar3pos;
    public GameObject Jar4;
    public Vector3 Jar4pos;
    public GameObject Jar5;
    public Vector3 Jar5pos;
    public GameObject Jar6;
    public Vector3 Jar6pos;
    public GameObject NewJar;
    public GameObject MainCam;
    public GameObject CraftCam;
    public GameObject ThoughtCloud;
    public GameObject PlayerObject;

    void Awake()
    {
        Jar1pos = Jar1.transform.position;
        Jar2pos = Jar2.transform.position;
        Jar3pos = Jar3.transform.position;
        Jar4pos = Jar4.transform.position;
        Jar5pos = Jar5.transform.position;
        Jar6pos = Jar6.transform.position;
        MainCam = GameObject.FindGameObjectWithTag("MainCamera");
        PlayerObject = GameObject.FindGameObjectWithTag("Bubba");
        ThoughtCloud = PlayerObject.transform.GetChild(2).gameObject;
        CraftCam = PlayerObject.transform.GetChild(3).gameObject;
        NewJar = GameObject.Find("NewJarMaster");
        Jar3D = NewJar.transform.GetChild(0).gameObject;
        CloudAnim = NewJar.transform.GetChild(1).gameObject;
        MainCam.SetActive(false);
        PlayerObject.transform.rotation = Quaternion.Euler(0, 180, 0);
        CraftCam.SetActive(true);
        ThoughtCloud.SetActive(true);
    }
            
        // Update is called once per frame
        void Update()
    {
        if (Jar1.GetComponent<pieceMovement>().locked == true && Jar2.GetComponent<pieceMovement>().locked == true && Jar3.GetComponent<pieceMovement>().locked == true && Jar4.GetComponent<pieceMovement>().locked == true && Jar5.GetComponent<pieceMovement>().locked == true && Jar6.GetComponent<pieceMovement>().locked == true)
        {
            CloudAnim.SetActive(true);
            Jar3D.SetActive(true);
            JarMaster.SetActive(false);
            MainCam.SetActive(true);
            CraftCam.SetActive(false);
            ThoughtCloud.SetActive(false);
        }

    }

    public void ResetItems()
    {
        Jar1.transform.position = Jar1pos;
        Jar1.GetComponent<pieceMovement>().locked = false;
        Jar2.transform.position = Jar2pos;
        Jar2.GetComponent<pieceMovement>().locked = false;
        Jar3.transform.position = Jar3pos;
        Jar3.GetComponent<pieceMovement>().locked = false;
        Jar4.transform.position = Jar4pos;
        Jar4.GetComponent<pieceMovement>().locked = false;
        Jar5.transform.position = Jar5pos;
        Jar5.GetComponent<pieceMovement>().locked = false;
        Jar6.transform.position = Jar6pos;
        Jar6.GetComponent<pieceMovement>().locked = false;
    }

}
