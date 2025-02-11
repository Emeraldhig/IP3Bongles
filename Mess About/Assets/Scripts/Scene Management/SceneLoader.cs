﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour // when using new scene - apply a specific tag to a new 'scene trigger'
{
    void OnTriggerEnter(Collider Bubba)
    {
        if (Bubba.CompareTag("Lagoon"))
        {
            SceneManager.LoadScene("MasterLagoon");
        }

        if (Bubba.CompareTag("Flytrap Path"))
        {
            SceneManager.LoadScene("MasterFlytrapPath");
        }

        if (Bubba.CompareTag("Jungle"))
        {
            SceneManager.LoadScene("MasterPathways");
        }

        if (Bubba.CompareTag("Campsite"))
        {
            SceneManager.LoadScene("MasterCampsite");
        }

        if (Bubba.CompareTag("Debug"))
        {
            SceneManager.LoadScene("SceneTest");
        }

        if (Bubba.CompareTag("EndScene"))
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}

// As Bubba is the 'trigger' don't put Is Trigger on any colliders.

// when enough scenes will change to switch case statements.
