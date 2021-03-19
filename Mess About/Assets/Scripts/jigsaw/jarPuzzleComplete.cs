using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jarPuzzleComplete : MonoBehaviour
{
    public GameObject[] pieces = new GameObject[6];
    public bool jarDone = false;

    // Update is called once per frame
    void Update()
    {
        if (pieces[0].GetComponent<pieceMovement>().locked 
            && pieces[1].GetComponent<pieceMovement>().locked 
            && pieces[2].GetComponent<pieceMovement>().locked
            && pieces[3].GetComponent<pieceMovement>().locked
            && pieces[4].GetComponent<pieceMovement>().locked
            && pieces[5].GetComponent<pieceMovement>().locked)
        {
            jarDone = true;
        }
    }
}
