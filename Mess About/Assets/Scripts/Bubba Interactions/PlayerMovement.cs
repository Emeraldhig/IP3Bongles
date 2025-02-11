﻿using System;
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
    public bool itemreveal;
    public GameObject InventoryObj;
    private Inventory Inventory;
    public GameObject walkToPoint;
    public Transform playerPosition;
    public bool movementBlock;
    public GameObject MainCamera;
    public GameObject ItemCam;
    public GameObject ActiveItem;
    public bool usingitem = false;
    public bool canuseitem = false;
    public bool minigameStarted = false;
    public bool flytrapComplete = false;

    private void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        InventoryObj = GameObject.FindGameObjectWithTag("Inventory");
        Inventory = InventoryObj.GetComponent<Inventory>();
        moving = false;
        itemreveal = false;
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

        if (itemreveal == false)
            m_Animator.SetBool("item reveal", false);

        if (itemreveal == true)
            m_Animator.SetBool("item reveal", true);

        if (Input.GetMouseButtonDown(0) && !movementBlock)
        {
            minigameStarted = false;
            canuseitem = false;
            walkToPoint.SetActive(true);
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                moving = true;
                walkToPoint.transform.position = hit.point;
                agent.SetDestination(hit.point);
            }
        }

        if ((int)playerPosition.position.x == (int)walkToPoint.transform.position.x)
        {
            moving = false;
            walkToPoint.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        IInventoryItem item = other.GetComponent<IInventoryItem>();
        if (item != null)
        {

            try
            {
                ActiveItem = transform.Find(item.Name).gameObject;
                ActiveItem.SetActive(true);
            }
            catch (Exception)
            {
                print("error");
            }



            itemreveal = true;
            Inventory.AddItem(item);
            MainCamera.SetActive(false);
            ItemCam.SetActive(true);
        }
    }
}
