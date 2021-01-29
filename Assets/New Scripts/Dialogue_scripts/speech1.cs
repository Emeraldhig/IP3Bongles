using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speech1 : MonoBehaviour
{
    public GameObject speaker2;
    public GameObject speaker;
    public Transform speechPosition;
    public GameObject speech;

    void OnMouseDown()
    {
        speech.transform.position = new Vector3(speechPosition.transform.position.x, speechPosition.transform.position.y, speechPosition.transform.position.z);
               speaker2.SetActive(true);
               Destroy(gameObject,1);
    }
}
