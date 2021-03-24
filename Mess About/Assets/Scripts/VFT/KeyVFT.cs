using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyVFT : MonoBehaviour
{
    public Animator anim;
    public GameObject FVTtrigger;
    public GameObject particles;
    public GameObject keylessVFT;
    public GameObject keyVFT;
    public bool idle;
    public bool spit;
    public int counter = 2400;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        idle = true;
    }

    // Update is called once per frame
    void Update()
    {
        spit = FVTtrigger.GetComponent<FlyTrap>().spit;

        if(idle)
        {
            anim.SetBool("idle", true);
        }
        if(spit)
        {
            counter--;
            anim.SetBool("spit", true);
            if(counter <= 0)
            {
                spit = false;
                keylessVFT.transform.position = keyVFT.transform.position;
                Destroy(keyVFT);
                particles.SetActive(false);
            }
        }
        else if(!spit)
        {
            anim.SetBool("spit", false);

        }
    }
}
