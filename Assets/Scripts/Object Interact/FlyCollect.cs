using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyCollect : MonoBehaviour
{
    [SerializeField]
    private GameObject ThisFly;

    [SerializeField]
    private GameObject net;

    [SerializeField]
    private bool caught = false;

    private bool netInUse = false;

  

    private void Update()
    {
        netInUse = net.GetComponent<DragObject>().getObjectUse();

        
    }
    void OnTriggerEnter(Collider collider)
    {

        
        
        Debug.Log("collision detected");

        if (netInUse)
        {
            if (collider.gameObject.tag == "Player")
            {
                caught = true;
                FlyPickUp.FlyValue += 1;
                ThisFly.SetActive(false);
            }
        }
    }

}
