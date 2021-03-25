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
        if (movementScript.usingitem && KeyStart)// && Inventory.Check("Portcullis Key"))
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
            Key.SetActive(true);
            bubba.SetActive(false);
            walkToPoint.SetActive(false);
            Inventory.Remove("Portcullis Key");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        KeyStart = true;
    }

    private void OnTriggerExit(Collider other)
    {
        KeyStart = false;
    }
}
