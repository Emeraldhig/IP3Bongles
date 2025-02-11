﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insects : MonoBehaviour
{
    // put the points from unity interface
    public Transform[] wayPointList;

    public int currentWayPoint = 0;
    Transform targetWayPoint;
    public GameObject flies;

    public float speed = 4f;

    
    

        // Update is called once per frame
        void Update()
    {
        // check if we have somewere to walk
        if (flies.GetComponent<FlyGame>().flyMoving)
        {
            if (currentWayPoint < this.wayPointList.Length)
            {
                if (targetWayPoint == null)
                    targetWayPoint = wayPointList[currentWayPoint];
                walk();
            }
        }
    }

    void walk()
    {
        

        // move towards the target
        transform.position = Vector3.MoveTowards(transform.position, targetWayPoint.position, speed * Time.deltaTime);

        if (transform.position == targetWayPoint.position)
        {
            currentWayPoint++;
            targetWayPoint = wayPointList[currentWayPoint];
        }

        if (currentWayPoint == 8)
        {
            currentWayPoint = 0;
        }
    }
}
