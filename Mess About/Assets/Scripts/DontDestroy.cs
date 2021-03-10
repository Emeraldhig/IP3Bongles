using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public GameObject item;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
