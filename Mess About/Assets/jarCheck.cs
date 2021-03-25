using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jarCheck : MonoBehaviour
{
    public GameObject hud;
    public GameObject invObj;
    public Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.FindGameObjectWithTag("HUD");
        invObj = GameObject.FindGameObjectWithTag("Inventory");
        inventory = invObj.GetComponent<Inventory>();

    }

    // Update is called once per frame
    void Update()
    {
        if (inventory.Check("Empty Jar") || inventory.Check("Jar of Flies"))
        {
            Destroy(gameObject);
        }
        
    }
}
