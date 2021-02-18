using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Naration : MonoBehaviour
{
    public void OnClick()
    {
        GetComponent<AudioSource>().Play();
    }
}
