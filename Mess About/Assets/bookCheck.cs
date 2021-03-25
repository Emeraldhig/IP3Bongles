using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookCheck : MonoBehaviour
{
    public GameObject bookMinigame;
    public GameObject hud;
    public GameObject invObj;
    public Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.FindGameObjectWithTag("HUD");
    }

    // Update is called once per frame
    void Update()
    {
        if (hud.GetComponent<HUD>().destroy[4])
        {
            Destroy(gameObject);
        }
    }
}
