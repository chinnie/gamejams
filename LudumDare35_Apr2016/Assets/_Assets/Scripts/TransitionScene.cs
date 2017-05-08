using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TransitionScene : MonoBehaviour {
    public GameObject otherGameObject;
    private SceneNameRecorder sceneNameRecorder;
    public int nextSceneToLoad;

    void Start ()
    {
        otherGameObject = GameObject.Find("SceneName");
        sceneNameRecorder = otherGameObject.GetComponent<SceneNameRecorder>();
        StartCoroutine(SceneDelay());    
    }
    


    IEnumerator SceneDelay()
    {
        yield return new WaitForSeconds(3);
        nextSceneToLoad = sceneNameRecorder.nextScene;
        SceneManager.LoadScene(nextSceneToLoad);
      // SceneManager.LoadScene("room2-2_large");
    }

}
