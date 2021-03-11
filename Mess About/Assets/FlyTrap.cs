using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyTrap : MonoBehaviour
{

    public Inventory Inventory;
    public GameObject InventoryObj;
    public GameObject Key;
    public GameObject EmptyJar;
    public bool FlyTrapStart;

    // Start is called before the first frame update
    void Start()
    {
        FlyTrapStart = false;
        InventoryObj = GameObject.FindGameObjectWithTag("Inventory");
        Inventory = InventoryObj.GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (FlyTrapStart && Input.GetKeyDown("e") && Inventory.Check("Jar Of Flies"))
        {
            Inventory.Remove("Jar of Flies");
            Inventory.AddItem(EmptyJar.GetComponent<IInventoryItem>());
            Inventory.AddItem(Key.GetComponent<IInventoryItem>());
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        FlyTrapStart = true;
    }

    private void OnTriggerExit(Collider other)
    {
        FlyTrapStart = false;
    }
}
