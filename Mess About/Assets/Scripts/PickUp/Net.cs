using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Net : MonoBehaviour, IInventoryItem
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
            return "Net";
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
        infoText.text = "Is this from the ship? It comes\nwith some tape could it be\nused so the flies can’t escape?";
        infoTitleText.text = "Net";
        info.SetActive(true);
        infoTitle.SetActive(true);
        pickUp.SetActive(true);
        infoBox.SetActive(true);
        gameObject.SetActive(false);
    }

}
