using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvHide : MonoBehaviour
{
    public Image img;
    public bool InvShow;
    public GameObject Panel;

    void Start()
    {
        Panel.SetActive(true);
        InvShow = true;
}

    public void InvMenu()
    {
        if (InvShow == true)
        {
            Panel.SetActive(false);
            InvShow = false;
        }
        else
        {
            Panel.SetActive(true);
            InvShow = true;
        }

    }

}
