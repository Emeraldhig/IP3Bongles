using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlyGame : MonoBehaviour
{
    public Inventory Inventory;
    public GameObject InventoryObj;
    public GameObject dragCheck;
    public GameObject MainCam;
    public GameObject FlyCam;
    public GameObject FlyNet;
    public bool FlyStart;
    public bool flyMoving;
    public GameObject PlayerObject;
    public PlayerMovement movementScript;
    public GameObject NoSparkles;
    public GameObject YesSparkles;
    public bool started = false;

    // Start is called before the first frame update
    void Start()
    {
        PlayerObject = GameObject.FindGameObjectWithTag("Bubba");
        movementScript = PlayerObject.GetComponent<PlayerMovement>();
        FlyStart = false;
        flyMoving = false;
        InventoryObj = GameObject.FindGameObjectWithTag("Inventory");
        dragCheck = GameObject.FindGameObjectWithTag("flyCheck");
        Inventory = InventoryObj.GetComponent<Inventory>();
    }

    private void Update()
    {
        if (started == false)
        {
            if (Inventory.Check("Bug Net") && Inventory.Check("Empty Jar"))
            {
                NoSparkles.SetActive(false);
                YesSparkles.SetActive(true);

                if (movementScript.usingitem && FlyStart)
                {
                    movementScript.minigameStarted = true;
                    movementScript.movementBlock = true;
                    movementScript.canuseitem = false;
                    MainCam.SetActive(false);
                    FlyCam.SetActive(true);
                    FlyNet.SetActive(true);
                    started = true;
                    flyMoving = true;
                }
            }
            else
            {
                NoSparkles.SetActive(true);
                YesSparkles.SetActive(false);
            }
        }
        else
        {
            NoSparkles.SetActive(false);
            YesSparkles.SetActive(false);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        FlyStart = true;
        other.GetComponent<PlayerMovement>().canuseitem = true;
    }

    private void OnTriggerExit(Collider other)
    {
        FlyStart = false;
        other.GetComponent<PlayerMovement>().canuseitem = false;
    }
}
