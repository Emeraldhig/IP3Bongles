using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour
{

    public Inventory Inventory;
    public GameObject Craft;
    public GameObject jar;
    public GameObject jarOverworld;
    public GameObject bubba;
    public GameObject BugNet;
    public GameObject infoBox;
    public GameObject pickUp;
    public GameObject infoTitle;
    public GameObject info;
    public GameObject crafting;
    public Vector3 cameraOldPos;
    Text infoTitleText;
    Text infoText;
    private PlayerMovement movementScript;

    // Start is called before the first frame update
    void Start()
    {
        
        Inventory.ItemAdded += InventoryScript_ItemAdded;
        infoText = info.GetComponent<Text>();
        infoTitleText = infoTitle.GetComponent<Text>();
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        bubba = GameObject.FindGameObjectWithTag("Bubba");
        movementScript = bubba.GetComponent<PlayerMovement>();
        if(sceneName == "MasterCampsite")
        {
            jarOverworld = GameObject.FindGameObjectWithTag("Jar");
        }
    }

        private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (Inventory.Check("Hoop") && Inventory.Check("Stick") && Inventory.Check("Net"))
        {
            Craft.SetActive(true);
        }
        else
        {
            Craft.SetActive(false);
        }


        if (Input.GetKeyDown("g"))
        {
            Inventory.ListItems();
        }
        if (sceneName == "MasterCampsite")
        {
            if (jarOverworld.GetComponent<EmptyJar>().jarMinigame)
            {
                jar.SetActive(true);
            }
            if (jar.GetComponent<jarPuzzleComplete>().jarDone)
            {
                jar.SetActive(false);
            }
        }
    }

    public void CraftNet()
    {
        

        if(crafting.GetComponent<CraftingFinish>().craftDone)
        {
             Inventory.Remove("Hoop");
             Inventory.Remove("Stick");
             Inventory.Remove("Net");
             Inventory.AddItem(BugNet.GetComponent<IInventoryItem>());
             InventoryScript_ItemRemoved();
             crafting.SetActive(false);
            bubba.GetComponent<PlayerMovement>().movementBlock = false;
        }
        else
        {
             crafting.SetActive(true);
            bubba.GetComponent<PlayerMovement>().movementBlock = true;
        }

    }


    private void InventoryScript_ItemAdded(object sender, InventoryEventArgs e)
    {
        Transform inventoryPanel = transform.Find("InventoryPanel");
        foreach(Transform slot in inventoryPanel)
        {
            Image image = slot.GetChild(0).GetComponent<Image>();
            Text text = slot.GetChild(1).GetComponent<Text>();

            movementScript.movementBlock = true;

            infoTitleText.text = e.Item.Name;
            info.SetActive(true);
            infoTitle.SetActive(true);
            pickUp.SetActive(true);
            infoBox.SetActive(true);

            if (infoTitleText.text == "Hoop")
            {
                infoText.text = "What’s this on the ground?\nA peculiar ring Maybe I\ncould use it to hold some string?";
            }
            if (infoTitleText.text == "Stick")
            {
                infoText.text = "A stick on the floor, so lonely\nand cold Yes this is perfect!\nThe net can be controlled!";
            }
            if (infoTitleText.text == "Net")
            {
                infoText.text = "Is this from the ship? It comes\nwith some tape could it be\nused so the flies can’t escape?";
            }
            if (infoTitleText.text == "Bug Net")
            {
                infoText.text = "I found this trash all on the floor\nand combined it together,Score!";
            }
            if (infoTitleText.text == "Empty Jar")
            {
                infoText.text = "Empty Jar test blah blah";
            }
            if (infoTitleText.text == "Jar Of Flies")
            {
                infoText.text = "Jar of Flies test blah blah";
            }
            if (infoTitleText.text == "Brainy's Book")
            {
                infoText.text = "Brainy's Book test blah blah";
            }
            if (infoTitleText.text == "Portcullis Key")
            {
                infoText.text = "Key test blah blah";
            }


            if (!image.enabled)
            {
                image.enabled = true;
                image.sprite = e.Item.Image;
            }
            if (!text.enabled)
            {
                text.enabled = true;
                text.text = e.Item.Name;

                break;
            }
        }
    }

    private void InventoryScript_ItemRemoved()
    {
        List<IInventoryItem> items = Inventory.GetItems();
        Transform inventoryPanel = transform.Find("InventoryPanel");
        for (int i = 0; i < inventoryPanel.childCount; i++)
        {
            Image image = inventoryPanel.GetChild(i).GetChild(0).GetComponent<Image>();
            Text text = inventoryPanel.GetChild(i).GetChild(1).GetComponent<Text>();

            if (i < items.Count)
            {
                image.enabled = true;
                image.sprite = items[i].Image;

                text.enabled = true;
                text.text = items[i].Name;
            }
            else
            {
                image.enabled = false;
                text.enabled = false;
            }
        }
    }

}
