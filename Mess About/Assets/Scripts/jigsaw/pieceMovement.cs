using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class pieceMovement : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IPointerUpHandler
{

    [SerializeField] private Canvas canvas;

    public GameObject pieceNumber;
    public int rotation = 0;
    public bool[] highlighted = new bool[6];

    //public Camera cameraObject;
    private RectTransform rectTransform;
    public bool jarGame = true;
    public bool clicked = false;
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

            clicked = true;

            /*rotation += 90;
            pieceNumber.transform.rotation = Quaternion.Euler(0, 0, rotation);*/

        }
       
        Debug.Log("OnPointerDown");
    }
    public void OnPointerUp(PointerEventData eventData)
    {

        clicked = false;
        Debug.Log("Pointer Up");
    }
    

}
