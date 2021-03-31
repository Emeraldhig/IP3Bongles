using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KeylessVFT : MonoBehaviour
{
    public Animator anim;
    public Animator BubbaAnim;
    public bool idle;
    public bool attack;
    public GameObject walktoPoint;
    public Vector3 BubbaSafe;
    public GameObject PlayerObject;
    public NavMeshAgent BubbaNavMesh;
    public GameObject VFTMaster;
    private string correctnameis = "NoKeyVFT1";
    private bool correctname = false;

    // Start is called before the first frame update
    void Start()
    {
        BubbaSafe = transform.parent.Find("BubbaSafe").position;
        PlayerObject = GameObject.FindGameObjectWithTag("Bubba");
        BubbaNavMesh = PlayerObject.GetComponent<NavMeshAgent>();
        anim = gameObject.GetComponent<Animator>();
        BubbaAnim = PlayerObject.GetComponent<Animator>();
        VFTMaster = transform.parent.gameObject;

        if (gameObject.name == correctnameis)
        {
            correctname = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (attack)
        {
            anim.SetBool("attack", true);

        }
        if(!attack)
        {
            anim.SetBool("attack", false);
        }

        if (correctname && anim.GetCurrentAnimatorStateInfo(0).IsName("spittingdone"))
        {
            VFTMaster.GetComponent<FlyTrap>().FlyDeathItem();
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bubba")
        {
            attack = true;
            BubbaNavMesh.SetDestination(BubbaSafe);
            BubbaAnim.SetBool("exclamation", true);
            BubbaAnim.SetBool("moving", false);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        attack = false;
        BubbaAnim.SetBool("exclamation", false);
    }
}
