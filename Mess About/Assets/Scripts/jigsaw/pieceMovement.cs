using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class pieceMovement : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    [SerializeField] private Canvas canvas;

    public GameObject pieceNumber;
    public int rotation = 0;
    public bool[] highlighted = new bool[6];

    //public Camera cameraObject;
    private RectTransform rectTransform;
    public bool jarGame = true;
    public bool locked = false;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!locked)
        {
            //float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        }
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if(jarGame)
        {
            if (pieceNumber.tag == "Piece1")
            {
                highlighted[0] = true;

                highlighted[1] = false;
                highlighted[2] = false;
                highlighted[3] = false;
                highlighted[4] = false;
                highlighted[5] = false;

            }
            else if (pieceNumber.tag == "Piece2")
            {
                highlighted[1] = true;

                highlighted[0] = false;
                highlighted[2] = false;
                highlighted[3] = false;
                highlighted[4] = false;
                highlighted[5] = false;
            }
            else if (pieceNumber.tag == "Piece3")
            {
                highlighted[2] = true;

                highlighted[0] = false;
                highlighted[1] = false;
                highlighted[3] = false;
                highlighted[4] = false;
                highlighted[5] = false;
            }
            else if (pieceNumber.tag == "Piece4")
            {
                highlighted[3] = true;

                highlighted[0] = false;
                highlighted[2] = false;
                highlighted[1] = false;
                highlighted[4] = false;
                highlighted[5] = false;
            }
            else if (pieceNumber.tag == "Piece5")
            {
                highlighted[4] = true;

                highlighted[0] = false;
                highlighted[2] = false;
                highlighted[3] = false;
                highlighted[1] = false;
                highlighted[5] = false;
            }
            else if (pieceNumber.tag == "Piece6")
            {
                highlighted[5] = true;

                highlighted[0] = false;
                highlighted[2] = false;
                highlighted[3] = false;
                highlighted[4] = false;
                highlighted[1] = false;
            }

            rotation += 90;
            pieceNumber.transform.rotation = Quaternion.Euler(0, 0, rotation);

        }
       
        Debug.Log("OnPointerDown");
    }
    
}
