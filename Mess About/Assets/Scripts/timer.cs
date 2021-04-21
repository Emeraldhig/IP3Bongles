using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public float time = 0.0f;
    public float waitTime = 108.0f;
    // Update is called once per frame
    void Update()
    {
        
        time += Time.deltaTime;

        if(time > waitTime)
        {
            SceneManager.LoadScene("MasterPathways");
        }
        if (Input.GetKeyDown("h")) 
        {
            SceneManager.LoadScene("MasterPathways");
        }
    }
}
