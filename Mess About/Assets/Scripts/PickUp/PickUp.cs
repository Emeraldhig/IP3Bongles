using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject infoBox;
    public GameObject pickUp;
    public GameObject infoTitle;
    public GameObject info;
    public GameObject speaker;
    private PlayerMovement movementScript;


    // Start is called before the first frame update
    void Start()
    {
        GameObject PlayerObject = GameObject.FindGameObjectWithTag("Bubba");
        movementScript = PlayerObject.GetComponent<PlayerMovement>();
    }
    public void PickUpClicked()
    {
        movementScript.movementBlock = false;
        speaker.SetActive(false);
        info.SetActive(false);
        infoTitle.SetActive(false);
        pickUp.SetActive(false);
        infoBox.SetActive(false);
    }
}
