using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    NavMeshAgent agent;
    Animator m_Animator;
    public bool moving;
    public GameObject InventoryObj;
    private Inventory Inventory;
    public GameObject walkToPoint;
    public Transform playerPosition;
    public bool movementBlock;
    public GameObject MainCamera;
    public GameObject ItemCam;

    private void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        InventoryObj = GameObject.FindGameObjectWithTag("Inventory");
        Inventory = InventoryObj.GetComponent<Inventory>();
        moving = false;
    }


    void Awake()
    {
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }


    private void Update()
    {
        if (moving == false)
            m_Animator.SetBool("moving", false);

        if (moving == true)
            m_Animator.SetBool("moving", true);

        if (Input.GetMouseButtonDown(0) && !movementBlock)
        {
            moving = true;
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                walkToPoint.transform.position = hit.point;
                agent.SetDestination(hit.point);
            }
        }

        if ((int)playerPosition.position.x == (int)walkToPoint.transform.position.x)
        {
            moving = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        IInventoryItem item = other.GetComponent<IInventoryItem>();
        if (item != null)
        {
            Inventory.AddItem(item);
            MainCamera.SetActive(false);
            ItemCam.SetActive(true);
        }
    }
}
