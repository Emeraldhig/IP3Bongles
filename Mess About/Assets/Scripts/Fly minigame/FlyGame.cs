using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlyGame : MonoBehaviour
{
    public Inventory Inventory;
    public GameObject bubba;
    public GameObject InventoryObj;
    public GameObject dragCheck;
    public GameObject MainCam;
    public GameObject FlyCam;
    public GameObject FlyNet;
    public bool FlyStart;
    public bool flyMoving;
    public GameObject PlayerObject;
    private PlayerMovement movementScript;

    // Start is called before the first frame update
    void Start()
    {
        PlayerObject = GameObject.FindGameObjectWithTag("Bubba");
        movementScript = PlayerObject.GetComponent<PlayerMovement>();
        FlyStart = false;
        flyMoving = false;
        InventoryObj = GameObject.FindGameObjectWithTag("Inventory");
        dragCheck = GameObject.FindGameObjectWithTag("flyCheck");
        bubba = GameObject.FindGameObjectWithTag("Bubba");
        Inventory = InventoryObj.GetComponent<Inventory>();
    }

    private void Update()
    {
        if (movementScript.usingitem && FlyStart && Inventory.Check("Bug Net") && Inventory.Check("Empty Jar"))
        {
            MainCam.SetActive(false);
            FlyCam.SetActive(true);
            FlyNet.SetActive(true);
            bubba.GetComponent<PlayerMovement>().movementBlock = true;
            flyMoving = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        FlyStart = true;
    }

    private void OnTriggerExit(Collider other)
    {
        FlyStart = false;
    }
}
