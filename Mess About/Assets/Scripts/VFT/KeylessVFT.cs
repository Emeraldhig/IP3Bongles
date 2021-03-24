using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeylessVFT : MonoBehaviour
{
    public Animator anim;
    public bool idle;
    public bool attack;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(idle)
        {
            anim.SetBool("idle", true);
        }
        if(attack)
        {
            anim.SetBool("attack", true);

        }
        if(!attack)
        {
            anim.SetBool("attack", false);
        }    
    }
    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Bubba")
        {
            attack = true;
            idle = false;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        attack = false;
        idle = true;
    }
}
