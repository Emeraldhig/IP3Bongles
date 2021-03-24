using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class highlighted : MonoBehaviour
{
    public bool[] highlight = new bool[6];
    public float[] rotation = new float[6];
    public GameObject[] pieceNumber = new GameObject[6];
    private RectTransform[] rectTransform = new RectTransform[6];
    public Image[] image = new Image[6];



    public void Start()
    {

        for(int i = 0; i < rotation.Length;i++)
        {
            rectTransform[i] = pieceNumber[i].GetComponent<RectTransform>();
            image[i] = pieceNumber[i].GetComponent<Image>();
            rotation[i] = rectTransform[i].eulerAngles.z;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        for (int i = 0; i < pieceNumber.Length; i++)
        {
            if (pieceNumber[i].GetComponent<pieceMovement>().clicked)
            {
                if (pieceNumber[i].tag == "Piece1")
                {
                    image[0].color = new Color(image[0].color.r, image[0].color.g, image[0].color.b, 1f);
                    highlight[0] = true;

                    highlight[1] = false;
                    image[1].color = new Color(image[1].color.r, image[1].color.g, image[1].color.b, 0.5f);
                    highlight[2] = false;
                    image[2].color = new Color(image[2].color.r, image[2].color.g, image[2].color.b, 0.5f);
                    highlight[3] = false;
                    image[3].color = new Color(image[3].color.r, image[3].color.g, image[3].color.b, 0.5f);
                    highlight[4] = false;
                    image[4].color = new Color(image[4].color.r, image[4].color.g, image[4].color.b, 0.5f);
                    highlight[5] = false;
                    image[5].color = new Color(image[5].color.r, image[5].color.g, image[5].color.b, 0.5f);

                }
                else if (pieceNumber[i].tag == "Piece2")
                {
                    image[1].color = new Color(image[1].color.r, image[1].color.g, image[1].color.b, 1f);
                    highlight[1] = true;

                    highlight[0] = false;
                    image[0].color = new Color(image[0].color.r, image[0].color.g, image[0].color.b, 0.5f);
                    highlight[2] = false;
                    image[2].color = new Color(image[2].color.r, image[2].color.g, image[2].color.b, 0.5f);
                    highlight[3] = false;
                    image[3].color = new Color(image[3].color.r, image[3].color.g, image[3].color.b, 0.5f);
                    highlight[4] = false;
                    image[4].color = new Color(image[4].color.r, image[4].color.g, image[4].color.b, 0.5f);
                    highlight[5] = false;
                    image[5].color = new Color(image[5].color.r, image[5].color.g, image[5].color.b, 0.5f);
                }
                else if (pieceNumber[i].tag == "Piece3")
                {
                    image[2].color = new Color(image[2].color.r, image[2].color.g, image[2].color.b, 1f);
                    highlight[2] = true;

                    highlight[0] = false;
                    image[0].color = new Color(image[0].color.r, image[0].color.g, image[0].color.b, 0.5f);
                    highlight[1] = false;
                    image[1].color = new Color(image[1].color.r, image[1].color.g, image[1].color.b, 0.5f);
                    highlight[3] = false;
                    image[3].color = new Color(image[3].color.r, image[3].color.g, image[3].color.b, 0.5f);
                    highlight[4] = false;
                    image[4].color = new Color(image[4].color.r, image[4].color.g, image[4].color.b, 0.5f);
                    highlight[5] = false;
                    image[5].color = new Color(image[5].color.r, image[5].color.g, image[5].color.b, 0.5f);
                }
                else if (pieceNumber[i].tag == "Piece4")
                {
                    image[3].color = new Color(image[3].color.r, image[3].color.g, image[3].color.b, 1f);
                    highlight[3] = true;

                    highlight[0] = false;
                    image[0].color = new Color(image[0].color.r, image[0].color.g, image[0].color.b, 0.5f);
                    highlight[2] = false;
                    image[2].color = new Color(image[2].color.r, image[2].color.g, image[2].color.b, 0.5f);
                    highlight[1] = false;
                    image[1].color = new Color(image[1].color.r, image[1].color.g, image[1].color.b, 0.5f);
                    highlight[4] = false;
                    image[4].color = new Color(image[4].color.r, image[4].color.g, image[4].color.b, 0.5f);
                    highlight[5] = false;
                    image[5].color = new Color(image[5].color.r, image[5].color.g, image[5].color.b, 0.5f);
                }
                else if (pieceNumber[i].tag == "Piece5")
                {
                    image[4].color = new Color(image[4].color.r, image[4].color.g, image[4].color.b, 1f);
                    highlight[4] = true;

                    highlight[0] = false;
                    image[0].color = new Color(image[0].color.r, image[0].color.g, image[0].color.b, 0.5f);
                    highlight[2] = false;
                    image[2].color = new Color(image[2].color.r, image[2].color.g, image[2].color.b, 0.5f);
                    highlight[3] = false;
                    image[3].color = new Color(image[3].color.r, image[3].color.g, image[3].color.b, 0.5f);
                    highlight[1] = false;
                    image[1].color = new Color(image[1].color.r, image[1].color.g, image[1].color.b, 0.5f);
                    highlight[5] = false;
                    image[5].color = new Color(image[5].color.r, image[5].color.g, image[5].color.b, 0.5f);
                }
                else if (pieceNumber[i].tag == "Piece6")
                {
                    image[5].color = new Color(image[5].color.r, image[5].color.g, image[5].color.b, 1f);
                    highlight[1] = true;

                    highlight[0] = false;
                    image[0].color = new Color(image[0].color.r, image[0].color.g, image[0].color.b, 0.5f);
                    highlight[2] = false;
                    image[2].color = new Color(image[2].color.r, image[2].color.g, image[2].color.b, 0.5f);
                    highlight[3] = false;
                    image[3].color = new Color(image[3].color.r, image[3].color.g, image[3].color.b, 0.5f);
                    highlight[4] = false;
                    image[4].color = new Color(image[4].color.r, image[4].color.g, image[4].color.b, 0.5f);
                    highlight[1] = false;
                    image[1].color = new Color(image[1].color.r, image[1].color.g, image[1].color.b, 0.5f);
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
                rotation[i] += 90;
                if(rotation[i] >=360)
                {
                    rotation[i] = 0;
                }
                pieceNumber[i].transform.rotation = Quaternion.Euler(0, 0, rotation[i]);
            }
        }
       
    }
}
