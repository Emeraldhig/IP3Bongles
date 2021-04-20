using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAnim : MonoBehaviour
{
    public Animator anim;
    public GameObject MainCam;
    public GameObject KeyCam;
    public GameObject Bubba;
    public GameObject NextCube;
    public GameObject Particles;
    public GameObject Gate;

    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponentInParent<Animator>();
        anim.SetBool("Open", true);
        Particles.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Done"))
        {
            MainCam.SetActive(true);
            Bubba.SetActive(true);
            KeyCam.SetActive(false);
            NextCube.SetActive(true);
            Gate.SetActive(false);
            gameObject.SetActive(false);
        }

    }
}
