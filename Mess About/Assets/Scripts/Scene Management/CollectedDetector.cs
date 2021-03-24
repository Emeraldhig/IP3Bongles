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

            Debug.Log("stick picked up");
            stickCollected += 1;
            GameObject.Find("Stick").SetActive(false);

            if(stickCollected == 1)
            {
                Debug.Log("stick incremented");
            }
        }

        if (Bubba.CompareTag("Hoop"))
        {
            // hoop pick up code
            Debug.Log("hoop picked up");
            hoopCollected += 1;
            GameObject.Find("Hoop").SetActive(false);

            if (hoopCollected == 1)
            {
                Debug.Log("hoop incremented");
            }
        }

        if (Bubba.CompareTag("Net"))
        {
            // net pick up code
            Debug.Log("Net picked up");
            netCollected += 1;
            GameObject.Find("Net").SetActive(false);

            if(netCollected == 1)
            {
                Debug.Log("net incremented");

            }
        }

        if (Bubba.CompareTag("Book"))
        {
            // book pick up code

            Debug.Log("Book picked up");
            bookCollected += 1;
            GameObject.Find("Book").SetActive(false);

            if (bookCollected == 1)
            {
                Debug.Log("book incremented");
            }
        }
    }
    void Awake()
    {
       if(netCollected == 1)
        {
            GameObject.Find("Net").SetActive(false);
        }
        if (hoopCollected == 1)
        {
            GameObject.Find("Hoop").SetActive(false);
        }
        if (stickCollected == 1)
        {
            GameObject.Find("Stick").SetActive(false);
        }
        if (bookCollected == 1)
        {
            GameObject.Find("Book").SetActive(false);
        }
    }
}
