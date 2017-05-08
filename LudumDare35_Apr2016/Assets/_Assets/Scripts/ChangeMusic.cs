using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeMusic : MonoBehaviour {
    //script to change music after a scene is loaded
    //from https://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/creating-a-scene-menu


//    public AudioClip level2Music;
//    public AudioClip level3Music;
    public AudioClip endMusic;
    private AudioSource source;

	// Use this for initialization
	void Awake () {
        source = GetComponent<AudioSource>();
	}

    void OnLevelWasLoaded(int scene) 
    {
        scene = SceneManager.GetActiveScene().buildIndex;
        if (scene == 9) // end scene
        {
            source.clip = endMusic;
            source.Play();
        }
    }
}
