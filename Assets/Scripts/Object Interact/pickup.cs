using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pickup : MonoBehaviour
{
    public GameObject invetory;

    private string sceneName;

    private Scene currentScene;

    


    private void Update()
    {
        currentScene = SceneManager.GetActiveScene();

        sceneName = currentScene.name;
    }
    void OnMouseDown()
    {
        if (sceneName == "Brainy")
        {
            invetory.transform.position = new Vector3(-23, 9, -15);
            Instantiate(invetory);
            invetory.transform.localScale = new Vector3(2, 2, 0);
            GameObject Infobox = GameObject.FindGameObjectWithTag("info");
            Destroy(Infobox);
            GameObject PlayerObject = GameObject.FindGameObjectWithTag("Player");
            PlayerObject.GetComponent<Move>().Moving();
            Destroy(gameObject);
        }
        else if(sceneName == "lake")
        {
            invetory.transform.position = new Vector3(-23, 9, -15);           
            Instantiate(invetory);
            invetory.transform.localScale = new Vector3(2, 2, 0);
            GameObject Infobox = GameObject.FindGameObjectWithTag("info");
            Destroy(Infobox);
            GameObject PlayerObject = GameObject.FindGameObjectWithTag("Player");
            PlayerObject.GetComponent<Move>().Moving();
            Destroy(gameObject);
        }
        else if(sceneName == "crossroads")
        {
            invetory.transform.position = new Vector3(-23, 9, -15);
            //Instantiate(invetory);
            invetory.transform.localScale = new Vector3(2, 2, 0);
            GameObject Infobox = GameObject.FindGameObjectWithTag("info");
            Destroy(Infobox);
            GameObject PlayerObject = GameObject.FindGameObjectWithTag("Player");
            PlayerObject.GetComponent<Move>().Moving();
            Destroy(gameObject);
        }
        
    }
}
