using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FlyNetMovement : MonoBehaviour
{


    public GameObject camera1;
    public Camera camera2;
    public GameObject FliesMaster;
    public int fliesCaught;
    private Vector3 screenPoint;
    private Vector3 offset;
    public float moveSpeed = 0.1f;
    public bool netInHand;


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
            //camera1.SetActive(true);
            FliesMaster.SetActive(false);
            SceneManager.LoadScene("Jungle Pathways");
        }
    }

    void OnMouseDrag()
    {
        netInHand = true;
        float distance_to_screen = camera2.WorldToScreenPoint(gameObject.transform.position).z;
        transform.position = camera2.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
    }
    private void OnMouseUp()
    {
        netInHand = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (netInHand)
        {
            Destroy(other.gameObject);
            fliesCaught++;
            print(fliesCaught);
        }
        
    }
}
