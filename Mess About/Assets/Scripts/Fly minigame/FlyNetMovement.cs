using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FlyNetMovement : MonoBehaviour
{
    public Inventory Inventory;
    public GameObject InventoryObj;
    public GameObject MainCam;
    public GameObject FlyCam;
    public GameObject FliesMaster;
    public int fliesCaught;
    private Vector3 screenPoint;
    private Vector3 offset;
    public float moveSpeed = 0.1f;
    public bool netInHand;
    public GameObject Flies;
    public GameObject PlayerObject;
    public PlayerMovement movementScript;

    // Start is called before the first frame update
    void Start()
    {
        fliesCaught = 0;
        InventoryObj = GameObject.FindGameObjectWithTag("Inventory");
        PlayerObject = GameObject.FindGameObjectWithTag("Bubba");
        movementScript = PlayerObject.GetComponent<PlayerMovement>();
        Inventory = InventoryObj.GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        movementScript.movementBlock = true;

        if (fliesCaught == 3)
        {
            MainCam.SetActive(true);
            FliesMaster.SetActive(false);
            FlyCam.SetActive(false);
            MainCam.SetActive(true);
            movementScript.movementBlock = false;
            Inventory.Remove("Empty Jar");
            Inventory.AddItem(Flies.GetComponent<IInventoryItem>());
        }
    }

    void OnMouseDrag()
    {
        netInHand = true;
        float distance_to_screen = FlyCam.GetComponent<Camera>().WorldToScreenPoint(gameObject.transform.position).z;
        transform.position = FlyCam.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
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
