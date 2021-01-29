using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keydrop : MonoBehaviour
{
    public GameObject speech3;
    public Transform speechPosition;
    public GameObject speaker3;
    void OnMouseDown()
    {
        speaker3.SetActive(true);
        speech3.transform.position = new Vector3(speechPosition.transform.position.x, speechPosition.transform.position.y, speechPosition.transform.position.z);
    }
}
