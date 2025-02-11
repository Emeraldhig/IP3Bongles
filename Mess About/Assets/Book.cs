﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Book : MonoBehaviour, IInventoryItem
{
    public bool bookMinigame = false;
    public bool trigger = false;


    public string Name
    {
        get
        {
            return "Brainy's Book";
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

    public AudioClip _Voicover = null;

    public AudioClip Voiceover
    {
        get
        {
            return _Voicover;
        }
    }

    public void OnPickup()
    {
        gameObject.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        bookMinigame = true;
    }
}
