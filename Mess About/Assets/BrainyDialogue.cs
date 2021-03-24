using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrainyDialogue : MonoBehaviour
{
    public GameObject hud;
    public bool interaction;
    void Start()
    {
        hud = GameObject.FindGameObjectWithTag("HUD");
        interaction = hud.GetComponent<HUD>().brainyInteraction;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        interaction = hud.GetComponent<HUD>().brainyInteraction;
    
        if(other.gameObject.tag == "Bubba")
        {
            if (interaction)
            {
                hud.GetComponent<HUD>().BrainyDialogue();
            }
            
        }
    }
}
