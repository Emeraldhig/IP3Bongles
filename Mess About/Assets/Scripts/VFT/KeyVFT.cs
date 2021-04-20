using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyVFT : MonoBehaviour
{
    public Animator anim;
    public GameObject VFTMaster;
    public GameObject particles;
    public GameObject keylessVFT;
    public GameObject keyVFT;
    public bool idle;
    public bool spit;

    public GameObject brainy;
    public Animation brainyAnim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        brainyAnim = brainy.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        spit = VFTMaster.GetComponent<FlyTrap>().spit;

        if (spit)
        {
            anim.SetBool("spit", true);
        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("spittingdone"))
        {
            VFTMaster.GetComponent<FlyTrap>().FlyDeathAnim();
            brainyAnim.Play("Brainy Exit Tree");
            gameObject.SetActive(false);
        }


        else if (!spit)
        {
            anim.SetBool("spit", false);

        }
    }
}
