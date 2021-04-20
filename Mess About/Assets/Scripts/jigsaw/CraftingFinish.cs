using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingFinish : MonoBehaviour
{
    public GameObject[] pieces = new GameObject[3];
    public bool craftDone = false;
    public GameObject Hoop;
    public Vector3 Hooppos;
    public GameObject Stick;
    public Vector3 Stickpos;
    public GameObject Net;
    public Vector3 Netpos;
    public GameObject hud;

    void Awake()
    {
        hud = GameObject.FindGameObjectWithTag("HUD");
        Hooppos = Hoop.transform.position;
        Stickpos = Stick.transform.position;
        Netpos = Net.transform.position;
    }

        private void Update()
    {
        if (pieces[0].GetComponent<pieceMovement>().locked && pieces[1].GetComponent<pieceMovement>().locked && pieces[2].GetComponent<pieceMovement>().locked)
        {
            hud.GetComponent<HUD>().CraftNetFinish();
        }
    }

    public void ResetItems()
    {
        Hoop.transform.position = Hooppos;
        Hoop.GetComponent<pieceMovement>().locked = false;
        Stick.transform.position = Stickpos;
        Stick.GetComponent<pieceMovement>().locked = false;
        Net.transform.position = Netpos;
        Net.GetComponent<pieceMovement>().locked = false;
    }
}
