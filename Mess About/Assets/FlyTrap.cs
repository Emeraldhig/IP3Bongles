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
    public bool spit;
    public GameObject PlayerObject;
    private PlayerMovement movementScript;

    // Start is called before the first frame update
    void Start()
    {
        PlayerObject = GameObject.FindGameObjectWithTag("Bubba");
        movementScript = PlayerObject.GetComponent<PlayerMovement>();
        FlyTrapStart = false;
        InventoryObj = GameObject.FindGameObjectWithTag("Inventory");
        Inventory = InventoryObj.GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (FlyTrapStart && movementScript.usingitem && Inventory.Check("Jar Of Flies"))
        {
            spit = true;
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
