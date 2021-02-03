using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetCombined : MonoBehaviour
{
    [SerializeField]
    private GameObject netPos;
   // [SerializeField]
   // private Transform hoopPos;
    [SerializeField]
    private GameObject stickPos;

    [SerializeField]
    private GameObject net;

    [SerializeField]
    private GameObject hoop;

    [SerializeField]
    private GameObject stick;

    [SerializeField]
    private GameObject fullNet;

    [SerializeField]
    private GameObject inv;

    bool done = false;
    void Start()
    {
        hoop = GameObject.FindGameObjectWithTag("Hoop");
    }

    // Update is called once per frame
    void Update()
    {


        if (!done)
        {
            if (netPos.activeSelf && stickPos.activeSelf)
            {
                if (netPos.transform.position.x == -22 && stickPos.transform.position.x == -22)
                {
                    Instantiate(fullNet);
                    Instantiate(inv);
                    inv.transform.position = new Vector3(-23, 9, -16);
                    fullNet.transform.position = new Vector3(-23, 9, -17);
                    Destroy(net);
                    Destroy(stick);
                    Destroy(hoop);
                    Destroy(netPos);
                    Destroy(stickPos);
                    done = true;
                }
            }
        }
    }
}
