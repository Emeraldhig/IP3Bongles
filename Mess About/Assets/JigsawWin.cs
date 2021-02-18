using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JigsawWin : MonoBehaviour
{
    public GameObject JarMaster;
    public GameObject CloudAnim;
    public GameObject Jar3D;
    public GameObject Jar1;
    public GameObject Jar2;
    public GameObject Jar3;
    public GameObject Jar4;
    public GameObject Jar5;
    public GameObject Jar6;

    // Update is called once per frame
    void Update()
    {
        if (Jar1.GetComponent<pieceMovement>().locked == true && Jar2.GetComponent<pieceMovement>().locked == true && Jar3.GetComponent<pieceMovement>().locked == true && Jar4.GetComponent<pieceMovement>().locked == true && Jar5.GetComponent<pieceMovement>().locked == true && Jar6.GetComponent<pieceMovement>().locked == true)
        {
            CloudAnim.SetActive(true);
            Jar3D.SetActive(true);
            JarMaster.SetActive(false);
        }
    }
}
