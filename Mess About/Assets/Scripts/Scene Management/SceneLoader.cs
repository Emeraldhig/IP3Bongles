using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour // when using new scene - apply a specific tag to a new 'scene trigger'
{
    void OnTriggerEnter(Collider Bubba)
    {
        if (Bubba.CompareTag("Lagoon"))
        {
            SceneManager.LoadScene("Lagoon Bubba");
        }

        if (Bubba.CompareTag("Flytrap path"))
        {
            SceneManager.LoadScene("Flytrap Path");
        }

        if (Bubba.CompareTag("Jungle"))
        {
            SceneManager.LoadScene("Jungle Pathways");
        }
    }
}

// As Bubba is the 'trigger' don't put Is Trigger on any colliders.

// when enough scenes will change to switch case statements.
