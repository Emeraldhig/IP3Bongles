using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    NavMeshAgent agent;
    Animator m_Animator;
    public bool moving;
    public Inventory inventory;
<<<<<<< Updated upstream
    public GameObject walkToPoint;
=======
    public Vector3 destinationPosition;
    public Transform playerPosition;
>>>>>>> Stashed changes

    private void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        moving = false;
    }

    private void Update()
    {
        if (moving == false)
            m_Animator.SetBool("moving", false);

        if (moving == true)
            m_Animator.SetBool("moving", true);

        if (Input.GetMouseButtonDown(0))
        {
            destinationPosition = Input.mousePosition;
            moving = true;
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                {
                walkToPoint.transform.position = hit.point;
                agent.SetDestination(hit.point);
                }
        }

        if (Input.GetMouseButtonDown(1))
        if (Input.GetMouseButtonUp(0) && playerPosition.position == destinationPosition)
        {
            moving = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        IInventoryItem item = other.GetComponent<IInventoryItem>();
        if (item != null)
        {
            inventory.AddItem(item);
        }
    }
}
