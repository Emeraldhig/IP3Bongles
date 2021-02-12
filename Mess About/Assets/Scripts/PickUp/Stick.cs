using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stick : MonoBehaviour, IInventoryItem
{
    public GameObject infoBox;
    public GameObject pickUp;
    public GameObject infoTitle;
    public GameObject info;
    Text infoTitleText;
    Text infoText;

    void Start()
    {
        infoText = info.GetComponent<Text>();
        infoTitleText = infoTitle.GetComponent<Text>();
    }

    public string Name
    {
        get
        {
            return "Stick";
        }
    }

    public Sprite _Image = null;

    public Sprite Image
    {
        get
        {
            return _Image;
        }
    }

    public void OnPickup()
    {
        infoText.text = "A stick on the floor, so lonely\nand cold Yes this is perfect!\nThe net can be controlled!";
        infoTitleText.text = "Stick";
        info.SetActive(true);
        infoTitle.SetActive(true);
        pickUp.SetActive(true);
        infoBox.SetActive(true);
        gameObject.SetActive(false);
    }

}
