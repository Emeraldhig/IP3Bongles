using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlyGame : MonoBehaviour
{
    public Inventory Inventory;
    public GameObject InventoryObj;
    public GameObject MainCam;
    public GameObject FlyCam;
    public GameObject FlyNet;
    public bool FlyStart;
    public bool flyMoving;

    // Start is called before the first frame update
    void Start()
    {
        FlyStart = false;
        flyMoving = false;
        InventoryObj = GameObject.FindGameObjectWithTag("Inventory");
        Inventory = InventoryObj.GetComponent<Inventory>();
    }

    private void Update()
    {
        if (FlyStart && GetComponent<MoveInvItem>().flyMinigame && Inventory.Check("Bug Net") && Inventory.Check("Empty Jar"))
        {
            MainCam.SetActive(false);
            FlyCam.SetActive(true);
            FlyNet.SetActive(true);
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
