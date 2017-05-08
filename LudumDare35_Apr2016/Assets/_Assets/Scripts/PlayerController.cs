using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    public string SceneName;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {

    }

	void FixedUpdate () {
        if (Input.GetKey("escape"))
            Application.Quit();
	}

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("CookieObject"))
        {
            other.gameObject.SetActive(false);
            SceneManager.LoadScene("0_transition");
        }
        else if (other.gameObject.CompareTag("DoorObject"))
        {
            //other.gameObject.SetActive(false);
            SceneManager.LoadScene("0_transition_door");
        }


    }

}
