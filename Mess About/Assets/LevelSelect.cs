using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LevelSelect : MonoBehaviour
{
   public void PlayScene()
    {
       /* Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        string Scene = EventSystem.current.currentSelectedGameObject.name;*/
        SceneManager.LoadScene("Intro Animation");
    }
}
