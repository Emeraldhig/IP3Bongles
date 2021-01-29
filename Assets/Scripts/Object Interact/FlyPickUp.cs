using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPickUp : MonoBehaviour
{
    // Start is called before the first frame update
    public static int FlyValue;
    public int InternalFly;
    public GameObject Fly1,Fly2,Fly3,Fly4;
    // Update is called once per frame
    void Update()
    {
        InternalFly = FlyValue;

        if (FlyValue == 1)
        {
            Fly1.SetActive(true);
        }
        if (FlyValue == 2)
        {
            Fly2.SetActive(true);
        }
        if (FlyValue == 3)
        {
            Fly3.SetActive(true);
        }
        if (FlyValue == 4)
        {
            Fly4.SetActive(true);
        }


    }
}
