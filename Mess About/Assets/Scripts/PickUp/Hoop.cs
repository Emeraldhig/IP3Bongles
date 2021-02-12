using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hoop : MonoBehaviour, IInventoryItem
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
            return "Hoop";
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
        infoText.text = "What’s this on the ground?\nA peculiar ring Maybe I\ncould use it to hold some string?";
        infoTitleText.text = "Hoop";
        info.SetActive(true);
        infoTitle.SetActive(true);
        pickUp.SetActive(true);
        infoBox.SetActive(true);
        gameObject.SetActive(false);
    }
}
