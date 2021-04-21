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
    public GameObject VFT1;
    public GameObject VFT2;
    public GameObject VFT3;

    public Animator VFT1Anim;
    public Animator VFT2Anim;
    public Animator VFT3Anim;
    public GameObject NoSparkles;
    public GameObject YesSparkles;

    // Start is called before the first frame update
    void Start()
    {
        PlayerObject = GameObject.FindGameObjectWithTag("Bubba");
        movementScript = PlayerObject.GetComponent<PlayerMovement>();
        FlyTrapStart = false;
        InventoryObj = GameObject.FindGameObjectWithTag("Inventory");
        Inventory = InventoryObj.GetComponent<Inventory>();
        VFT1 = transform.GetChild(1).gameObject;
        VFT2 = transform.GetChild(2).gameObject;
        VFT3 = transform.GetChild(3).gameObject;
        VFT1Anim = VFT1.GetComponent<Animator>();
        VFT2Anim = VFT2.GetComponent<Animator>();
        VFT3Anim = VFT3.GetComponent<Animator>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Inventory.Check("Jar Of Flies"))
        {
            NoSparkles.SetActive(false);
            YesSparkles.SetActive(true);

            if (FlyTrapStart && movementScript.usingitem)
            {
                movementScript.minigameStarted = true;
                movementScript.canuseitem = false;
                movementScript.usingitem = false;
                movementScript.flytrapComplete = true;
                spit = true;
            }
        }
        else
        {
            NoSparkles.SetActive(true);
            YesSparkles.SetActive(false);
        }
    }

    public void FlyDeathAnim()
    {
        VFT1.GetComponent<BoxCollider>().enabled = false;
        VFT2.GetComponent<BoxCollider>().enabled = false;
        VFT3.GetComponent<BoxCollider>().enabled = false;
        VFT1Anim.Play("SpinDeath");
        VFT2Anim.Play("SpinDeath");
        VFT3Anim.Play("SpinDeath");
       
    }

    public void FlyDeathItem()
    {
        Inventory.Remove("Jar of Flies");
        Inventory.AddItem(EmptyJar.GetComponent<IInventoryItem>());
        Inventory.AddItem(Key.GetComponent<IInventoryItem>());
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        FlyTrapStart = true;
        other.GetComponent<PlayerMovement>().canuseitem = true;
    }

    private void OnTriggerExit(Collider other)
    {
        FlyTrapStart = false;
        other.GetComponent<PlayerMovement>().canuseitem = false;
    }
}
