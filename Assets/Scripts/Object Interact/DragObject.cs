using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 mOffset;

    private float mZCoord;

    private bool objectInUse = false;


 

    void OnMouseDown()
    {
        Debug.Log("net picked up");
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseAsWorldPos();
        objectInUse = true;
        // store offset = gameobject world pos - mouse world pos 
    }

    void OnMouseUp()
    {
        objectInUse = false;
    }

    private Vector3 GetMouseAsWorldPos()
    {
        // pixel coordinates (x,y)
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }


void OnMouseDrag()
     
    {
       transform.position = GetMouseAsWorldPos() + mOffset;
    }
    public bool getObjectUse()
    {
        return objectInUse;
    }
}
