using UnityEngine;
using UnityEngine.SceneManagement;

public class RestoreBubbaPosition : MonoBehaviour
{
    void Start() // initial check to see if scene has been accessed before.
    {
        int sceneGuide = SceneManager.GetActiveScene().buildIndex;
        if (PositionSaveGuide.positionSaver.ContainsKey(sceneGuide))
        {
            transform.position = PositionSaveGuide.positionSaver[sceneGuide];
        }
    }

    void OnDestroy() // Saving bubbas position before he leaves the scene.
    {
        int sceneGuide = SceneManager.GetActiveScene().buildIndex;
        PositionSaveGuide.positionSaver[sceneGuide] = transform.position - new Vector3(0, 0, 3f);
    }
}
