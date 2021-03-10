using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TravelBack : MonoBehaviour
{
    public GameObject button;
    public bool test;
    // Start is called before the first frame update
    void Awake()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string name = currentScene.name;

       /* if(name == "RamagePathways")
        {
            button.SetActive(false);
            test = true;
        }
        else
        {
            button.SetActive(true);
            test = false;
        }*/
    }

    public void loadScene()
    {
        SceneManager.LoadScene("RamagePathways");
    }
}
