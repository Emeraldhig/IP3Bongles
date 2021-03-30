using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedDetector : MonoBehaviour
{
    public int stickCollected = 0;
    public int hoopCollected = 0;
    public int netCollected = 0;
    public int bookCollected = 0;


    void OnTriggerEnter(Collider Bubba)
    {
        if (Bubba.CompareTag("Stick"))
        {
            // stick pick up code 
            stickCollected += 1;

            if(stickCollected == 1)
            {
            }
        }

        if (Bubba.CompareTag("Hoop"))
        {
            // hoop pick up code
            hoopCollected += 1;

            if (hoopCollected == 1)
            {
            }
        }

        if (Bubba.CompareTag("Net"))
        {
            // net pick up code
            netCollected += 1;

            if(netCollected == 1)
            {
            }
        }

        if (Bubba.CompareTag("Book"))
        {
            // book pick up code
            bookCollected += 1;

            if (bookCollected == 1)
            {
            }
        }
    }
    void Awake()
    {
       if(netCollected == 1)
        {
            GameObject.FindGameObjectWithTag("Net").SetActive(false);
        }
        if (hoopCollected == 1)
        {
            GameObject.FindGameObjectWithTag("Hoop").SetActive(false);
        }
        if (stickCollected == 1)
        {
            GameObject.FindGameObjectWithTag("Stick").SetActive(false);
        }
        if (bookCollected == 1)
        {
            GameObject.FindGameObjectWithTag("Book").SetActive(false);
        }
    }
}
