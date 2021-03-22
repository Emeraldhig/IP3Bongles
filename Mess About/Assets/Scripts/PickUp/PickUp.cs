using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUp : MonoBehaviour
{
    public GameObject infoBox;
    public GameObject pickUp;
    public GameObject infoTitle;
    public GameObject info;
    public GameObject tutorialMaster;
    private PlayerMovement movementScript;


    // Start is called before the first frame update
    void Start()
    { 
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        GameObject PlayerObject = GameObject.FindGameObjectWithTag("Bubba");
        movementScript = PlayerObject.GetComponent<PlayerMovement>();
    }

    public void PickUpClicked()
    {
        movementScript.movementBlock = false;
        info.SetActive(false);
        infoTitle.SetActive(false);
        pickUp.SetActive(false);
        infoBox.SetActive(false);
    }


    public void TutorialNext()
    {
        movementScript.movementBlock = false;
        tutorialMaster.SetActive(false);
    }
}
