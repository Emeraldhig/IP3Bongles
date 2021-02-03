using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompassScript : MonoBehaviour
{
    [SerializeField]
    private bool[] collected = new bool[1];

    [SerializeField]
    private GameObject Compass;

    private Animation anim;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < collected.Length; i++)
        {
            if (!collected[i]) { collected[i] = GameObject.Find("Big Bubba v0.3").GetComponent<Move>().objectObtained(); }
        }

        anim = Compass.GetComponent<Animation>();
        anim.Play("needleSpin");

        for (int i = 0; i < collected.Length; i++)
        {
            if (collected[i]) { anim.Stop("needleSpin"); }
        }
    }
}
