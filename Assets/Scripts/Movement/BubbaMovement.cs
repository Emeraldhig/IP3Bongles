using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbaMovement : MonoBehaviour
{

        [SerializeField]
        private GameObject Bubba;

        private float BubbaSpeed = 5.0f;


    // Update is called once per frame
    void Update()
    {
        BubbaSpeed = 0.2f;
        //   transform.position.X (0, BubbaSpeed, 0, Space.World);
    }

}
