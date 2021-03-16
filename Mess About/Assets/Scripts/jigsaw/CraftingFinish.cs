using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingFinish : MonoBehaviour
{
    public GameObject[] pieces = new GameObject[3];
    public bool craftDone = false;

    private void Update()
    {
        if (pieces[0].GetComponent<pieceMovement>().locked && pieces[1].GetComponent<pieceMovement>().locked && pieces[2].GetComponent<pieceMovement>().locked)
        {
            craftDone = true;
        }
    }
}
