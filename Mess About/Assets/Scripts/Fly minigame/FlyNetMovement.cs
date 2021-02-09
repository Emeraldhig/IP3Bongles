using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyNetMovement : MonoBehaviour
{


    public GameObject camera1;
    public Camera camera2;
    public GameObject FliesMaster;
    public int fliesCaught;
    private Vector3 screenPoint;
    private Vector3 offset;
    public float moveSpeed = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        fliesCaught = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (fliesCaught == 3)
        {
            camera1.SetActive(true);
            FliesMaster.SetActive(false);
        }
    }

    void OnMouseDrag()
    {
        float distance_to_screen = camera2.WorldToScreenPoint(gameObject.transform.position).z;
        transform.position = camera2.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        fliesCaught++;
        print(fliesCaught);
    }
}
