using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneNameRecorder : MonoBehaviour {

    public int currentScene = 0;
    public int nextScene = 1;

    void Update()
    {
   

        if ((SceneManager.GetActiveScene().name != "0_transition")&&(SceneManager.GetActiveScene().name != "0_transition_door"))
        {
            currentScene = SceneManager.GetActiveScene().buildIndex; 
            nextScene = currentScene +1;
        }


    }
}
