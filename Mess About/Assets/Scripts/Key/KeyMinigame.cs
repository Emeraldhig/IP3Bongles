using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyMinigame : MonoBehaviour
{
    public Inventory Inventory;
    public GameObject InventoryObj;
    public GameObject bubba;
    public GameObject walkToPoint;
    public GameObject camera1;
    public GameObject camera2;
    public GameObject Key;
    public bool KeyStart;
    public GameObject PlayerObject;
    private PlayerMovement movementScript;
    public GameObject NoSparkles;
    public GameObject YesSparkles;
    public bool started = false;

    // Start is called before the first frame update
    void Start()
    {
        PlayerObject = GameObject.FindGameObjectWithTag("Bubba");
        movementScript = PlayerObject.GetComponent<PlayerMovement>();
        KeyStart = false;
        InventoryObj = GameObject.FindGameObjectWithTag("Inventory");
        Inventory = InventoryObj.GetComponent<Inventory>();
    }

    private void Update()
    {
        if (started == false)
        {
            if (Inventory.Check("Portcullis Key"))
            {
                NoSparkles.SetActive(false);
                YesSparkles.SetActive(true);

                if (movementScript.usingitem && KeyStart)
                {
                    movementScript.minigameStarted = true;
                    camera1.SetActive(false);
                    camera2.SetActive(true);
                    Key.SetActive(true);
                    bubba.SetActive(false);
                    started = true;
                    Inventory.Remove("Portcullis Key");
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
        KeyStart = true;
        other.GetComponent<PlayerMovement>().canuseitem = true;
    }

    private void OnTriggerExit(Collider other)
    {
        KeyStart = false;
        other.GetComponent<PlayerMovement>().canuseitem = false;
    }
}
