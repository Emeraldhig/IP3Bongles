using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectUsage : MonoBehaviour
{
    [SerializeField]
    private GameObject currentObject;

    [SerializeField]
    private GameObject interactable;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Collectable")
        {
            SceneManager.LoadScene("fly catching");
        }
        
    }
    
}
