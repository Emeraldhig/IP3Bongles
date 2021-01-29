using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadPrevLevel : MonoBehaviour
{
    

    // Update is called once per frame
    public void Update()
    {
        SceneManager.LoadScene("crossroads");
    }
}
