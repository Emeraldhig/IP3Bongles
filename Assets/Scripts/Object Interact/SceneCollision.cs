using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneCollision : MonoBehaviour
{
    public bool Lake, Jungle;



private void OnMouseDown()
    {
        if (gameObject.tag == "jungleBox")
            Jungle = true;
        if (gameObject.tag == "lakeBox")
            Lake = true;

        GameObject PlayerObject = GameObject.FindGameObjectWithTag("Player");
        PlayerObject.GetComponent<Move>().Moving();
    }
}
