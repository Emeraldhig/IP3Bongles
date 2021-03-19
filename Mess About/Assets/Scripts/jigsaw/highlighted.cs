using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class highlighted : MonoBehaviour
{
    public bool[] highlight = new bool[6];
    public int rotation = 0;
    public GameObject[] pieceNumber = new GameObject[6];


 
    // Update is called once per frame
    void Update()
    {
        
        for (int i = 0; i < pieceNumber.Length; i++)
        {
            if (pieceNumber[i].GetComponent<pieceMovement>().clicked)
            {
                if (pieceNumber[i].tag == "Piece1")
                {
                    highlight[0] = true;

                    highlight[1] = false;
                    highlight[2] = false;
                    highlight[3] = false;
                    highlight[4] = false;
                    highlight[5] = false;

                }
                else if (pieceNumber[i].tag == "Piece2")
                {
                    highlight[1] = true;

                    highlight[0] = false;
                    highlight[2] = false;
                    highlight[3] = false;
                    highlight[4] = false;
                    highlight[5] = false;
                }
                else if (pieceNumber[i].tag == "Piece3")
                {
                    highlight[2] = true;

                    highlight[0] = false;
                    highlight[1] = false;
                    highlight[3] = false;
                    highlight[4] = false;
                    highlight[5] = false;
                }
                else if (pieceNumber[i].tag == "Piece4")
                {
                    highlight[3] = true;

                    highlight[0] = false;
                    highlight[2] = false;
                    highlight[1] = false;
                    highlight[4] = false;
                    highlight[5] = false;
                }
                else if (pieceNumber[i].tag == "Piece5")
                {
                    highlight[4] = true;

                    highlight[0] = false;
                    highlight[2] = false;
                    highlight[3] = false;
                    highlight[1] = false;
                    highlight[5] = false;
                }
                else if (pieceNumber[i].tag == "Piece6")
                {
                    highlight[5] = true;

                    highlight[0] = false;
                    highlight[2] = false;
                    highlight[3] = false;
                    highlight[4] = false;
                    highlight[1] = false;
                }
            }
        }
    }
    public void OnClick()
    {
        for(int i = 0; i < highlight.Length; i++)
        {
            if(highlight[i])
            {
                rotation += 90;
                if(rotation >=360)
                {
                    rotation = 0;
                }
                pieceNumber[i].transform.rotation = Quaternion.Euler(0, 0, rotation);
            }
        }
       
    }
}
