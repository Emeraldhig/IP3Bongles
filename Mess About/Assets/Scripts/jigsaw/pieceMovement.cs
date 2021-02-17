using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pieceMovement : MonoBehaviour
{
    public Camera cameraObject;
    public bool locked = false;
    void OnMouseDrag()
    {
        if (!locked)
        {
            float distance_to_screen = cameraObject.WorldToScreenPoint(gameObject.transform.position).z;
            transform.position = cameraObject.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
        }
    }
}
