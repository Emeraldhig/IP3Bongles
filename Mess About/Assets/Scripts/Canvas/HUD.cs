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
    public GameObject book;
    public GameObject bookOverworld;
    public GameObject jarOverworld;
    public GameObject BugNet;
    public GameObject infoBox;
    public GameObject pickUp;
    public GameObject infoTitle;
    public GameObject info;
    public GameObject crafting;
    public int tutorialstage;
    public GameObject MainCam;
    public GameObject CraftCam;
    public GameObject ThoughtCloud;
    Text infoTitleText;
    Text infoText;
    public GameObject tutorialMaster;
    public Text tutorialText;
    public GameObject PlayerObject;
    private PlayerMovement movementScript;
    public GameObject InventoryObject;
    public GameObject ItemButton;
    public GameObject CraftButton;
    public AudioSource voiceover;
    public GameObject EmptyJarItem;

    // Start is called before the first frame update
    void Start()
    {
        tutorialstage = 0;
        Inventory.ItemAdded += InventoryScript_ItemAdded;
        infoText = info.GetComponent<Text>();
        infoTitleText = infoTitle.GetComponent<Text>();
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        MainCam = GameObject.FindGameObjectWithTag("MainCamera");
        PlayerObject = GameObject.FindGameObjectWithTag("Bubba");
        ThoughtCloud = PlayerObject.transform.GetChild(2).gameObject;
        CraftCam = PlayerObject.transform.GetChild(3).gameObject;
        movementScript = PlayerObject.GetComponent<PlayerMovement>();

        if (sceneName == "MasterCampsite")
        {
            jarOverworld = GameObject.FindGameObjectWithTag("Jar");
            bookOverworld = GameObject.FindGameObjectWithTag("Book");
        }



        if (sceneName == "MasterLagoon")
        {
            if (Inventory.Check("Bug Net"))
            {
                movementScript.movementBlock = true;
                tutorialMaster.SetActive(true);
                tutorialText.text = "Press E when near objects to use items on them";
            }
        }

        if (tutorialstage == 0)
        {
            movementScript.movementBlock = true;
            tutorialMaster.SetActive(true);
            tutorialText.text = "Tap on the Screen to move\nYou can move into a new area by walking into an Archway";
        }
        else if (tutorialstage == 1)
        {
            movementScript.movementBlock = true;
            tutorialMaster.SetActive(true);
            tutorialText.text = "Tap on items to Pick them up\nYou can talk to other characters too";
        }
        else
        {
            movementScript.movementBlock = false;
        }

    }

    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        InventoryScript_ItemRemoved();


        if (Input.GetKeyDown("g"))
        {
            Inventory.ListItems();
        }

        if (sceneName == "MasterCampsite")
        {
            if (jar.GetComponent<jarPuzzleComplete>().jarDone)
            {
                jarOverworld.GetComponent<BrokenJar>().jarMinigame = false;
                jar.SetActive(false);
                InventoryObject.SetActive(true);
                ItemButton.SetActive(true);
                movementScript.movementBlock = false;
                Inventory.AddItem(EmptyJarItem.GetComponent<IInventoryItem>());
            }
            if (bookOverworld.GetComponent<Book>().trigger)
            {
                book.SetActive(true);
            }
            if (book.GetComponent<QuestionChange>().complete)
            {
                book.SetActive(false);
            }
        }

    }

    public void CraftNet()
    {
        if (crafting.GetComponent<CraftingFinish>().craftDone)
        {
            Inventory.Remove("Hoop");
            Inventory.Remove("Stick");
            Inventory.Remove("Net");
            Inventory.AddItem(BugNet.GetComponent<IInventoryItem>());
            InventoryScript_ItemRemoved();
            crafting.SetActive(false);
            Craft.SetActive(false);
            InventoryObject.SetActive(true);
            ItemButton.SetActive(true);
            MainCam.SetActive(true);
            CraftCam.SetActive(false);
            ThoughtCloud.SetActive(false);
            PlayerObject.GetComponent<PlayerMovement>().movementBlock = false;
        }
        else
        {
            crafting.SetActive(true);
            InventoryObject.SetActive(false);
            ItemButton.SetActive(false);
            MainCam.SetActive(false);
            PlayerObject.transform.rotation = Quaternion.Euler(0, 180, 0);
            CraftCam.SetActive(true);
            ThoughtCloud.SetActive(true);
            PlayerObject.GetComponent<PlayerMovement>().movementBlock = true;
        }
    }


    private void InventoryScript_ItemAdded(object sender, InventoryEventArgs e)
    {
        Transform inventoryPanel = transform.Find("InventoryPanel");
        voiceover.clip = e.Item.Voiceover;
        foreach (Transform slot in inventoryPanel)
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
                infoText.text = "What a useful thing,\nA hoop can be,\nPerhaps we can use it,\nTo set Brainy free.";
            }
            if (infoTitleText.text == "Stick")
            {
                infoText.text = "It's nothing special,\nJust a stick,\nBut with something else,\nIt might do the trick.";
            }
            if (infoTitleText.text == "Net")
            {
                infoText.text = "This net’s a mess, \nIt's tangled a bit,\nBut with some crafty work,\nIt just might fit.";
            }
            if (infoTitleText.text == "Bug Net")
            {
                infoText.text = "Look at what you made,\nIt's a wonderful net,\nYou'll catch loads of flies,\nWith that I'll bet.";
            }
            if (infoTitleText.text == "Empty Jar")
            {
                infoText.text = "What a wonderful job,\nLooks good as new,\nHow much can it hold ?\nI’m sure it's a few.";
            }
            if (infoTitleText.text == "Jar Of Flies")
            {
                infoText.text = "The jar is full,\nThat's all we need,\nLet's go back to Brainy,\nWe've got plants to feed.";
            }
            if (infoTitleText.text == "Brainy's Book")
            {
                infoText.text = "Well done Bubba,\nYou found Brainy's book,\nTo help him out,\nWe should give it a look.";
            }
            if (infoTitleText.text == "Portcullis Key")
            {
                infoText.text = "We solved the problem,\nBrainy’s safe as can be,\nNow where can we go,\nUsing this key?";
            }
            if (infoTitleText.text == "Broken Jar")
            {
                infoText.text = "Careful! it's sharp,\nYou must take care,\nBut there might be something here,\nYou can repair.";
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

    public void PickUpClicked()
    {
        movementScript.movementBlock = false;
        info.SetActive(false);
        infoTitle.SetActive(false);
        pickUp.SetActive(false);
        infoBox.SetActive(false);

        if (tutorialstage == 2)
        {
            if (Inventory.Check("Hoop") && Inventory.Check("Stick") && Inventory.Check("Net"))
            {
                movementScript.movementBlock = true;
                tutorialMaster.SetActive(true);
                tutorialText.text = "Use the Craft button to make new items";
                Craft.SetActive(true);
            }
            else
            {
                Craft.SetActive(false);
            }

        }

        if (Inventory.Check("Broken Jar"))
        {
            jar.SetActive(true);
            InventoryObject.SetActive(false);
            ItemButton.SetActive(false);
            info.SetActive(false);
            infoTitle.SetActive(false);
            pickUp.SetActive(false);
            infoBox.SetActive(false);
            Inventory.Remove("Broken Jar");
            InventoryScript_ItemRemoved();
        }

    }


    public void TutorialNext()
    {
        movementScript.movementBlock = false;
        tutorialMaster.SetActive(false);
        tutorialstage++;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
