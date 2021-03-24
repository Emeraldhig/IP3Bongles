using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class arrowScript : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public GameObject key;

    public void OnMouseOver()
    {
        key.GetComponent<KeyRotate>().arrowPressed = true;
    }
    public void OnMouseExit()
    {
        key.GetComponent<KeyRotate>().arrowPressed = false;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        
        Debug.Log("pointer down");
    }
    public void OnPointerUp(PointerEventData eventData)
    {

        
        Debug.Log("Pointer Up");
    }

}
