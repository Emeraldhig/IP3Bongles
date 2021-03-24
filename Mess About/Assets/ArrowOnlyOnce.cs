using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowOnlyOnce : MonoBehaviour
{
    public bool show = true;

        // Start is called before the first frame update
        void Awake()
    {
        if (show == true)
        {
            print("hello");
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
            show = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
