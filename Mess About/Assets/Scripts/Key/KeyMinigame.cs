using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyMinigame : MonoBehaviour
{
    public Inventory Inventory;
    public GameObject InventoryObj;
    public GameObject camera1;
    public GameObject camera2;
    public GameObject Key;
    public bool KeyStart;

    // Start is called before the first frame update
    void Start()
    {
        KeyStart = false;
        InventoryObj = GameObject.FindGameObjectWithTag("Inventory");
        Inventory = InventoryObj.GetComponent<Inventory>();
    }

    private void Update()
    {
        if (KeyStart && Inventory.Check("Portcullis Key") && Input.GetKeyDown("e"))
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
            Key.SetActive(true);
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
