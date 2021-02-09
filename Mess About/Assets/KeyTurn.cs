using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTurn : MonoBehaviour
{

    public Camera camera1;
    public GameObject camera1Obj;
    public GameObject camera2;
    private Vector3 screenPoint;
    private Vector3 offset;
    public float moveSpeed = 0.1f;
    public GameObject Key1;
    public GameObject Key2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnMouseDrag()
    {
        float distance_to_screen = camera1.WorldToScreenPoint(gameObject.transform.position).z;
        transform.position = camera1.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
    }

    private void OnTriggerEnter(Collider other)
    {
        print("hello");
        camera2.SetActive(true);
        Key2.SetActive(true);
        camera1Obj.SetActive(false);
        Key1.SetActive(false);
    }

}
