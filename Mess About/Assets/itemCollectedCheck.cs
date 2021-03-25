using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class itemCollectedCheck : MonoBehaviour
{
    public GameObject hud;
    public GameObject invObj;
    public Inventory inventory;
    
    public bool[] destroy = new bool[5];
    void Start()
    {
        hud = GameObject.FindGameObjectWithTag("HUD");
        invObj = GameObject.FindGameObjectWithTag("Inventory");
        inventory = invObj.GetComponent<Inventory>();
        
    }

    // Update is called once per frame
    void Update()
    {
        destroy = hud.GetComponent<HUD>().destroy;
        hud.GetComponent<HUD>().itemCheck();
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "MasterPathways")
        {
            if (inventory.Check("Net") || inventory.Check("Bug Net"))
            {
                Destroy(gameObject);
            }
        }
        if (sceneName == "MasterFlytrapPath")
        {
            if (inventory.Check("Hoop") || inventory.Check("Bug Net"))
            {
                Destroy(gameObject);
            }
        }
        if (sceneName == "MasterCampsite")
        {
            if (inventory.Check("Stick") || inventory.Check("Bug Net"))
            {
                Destroy(gameObject);
            }
            
        }
    }

}

