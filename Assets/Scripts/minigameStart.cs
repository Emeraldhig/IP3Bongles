using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class minigameStart : MonoBehaviour
{
    [SerializeField]
    private GameObject infobox;
    [SerializeField]
    private Transform infobox_pos;
    [SerializeField]
    private GameObject pickup;
    [SerializeField]
    private Transform pickup_position;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collectable")
        {
            SceneManager.LoadScene("Fly catching");
        }
    }
}
