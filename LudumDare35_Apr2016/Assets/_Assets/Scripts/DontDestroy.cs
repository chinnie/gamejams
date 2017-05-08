using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

    //the game object this script is attached to will not be destroyed when a new scene is loaded
    //script from https://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/creating-a-scene-menu

	// Use this for initialization
	void Awake () {
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
