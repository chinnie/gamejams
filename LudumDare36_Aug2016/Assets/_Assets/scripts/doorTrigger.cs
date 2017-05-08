using UnityEngine;
using System.Collections;

//attach this script to the trigger gameObject

public class doorTrigger : MonoBehaviour {

    public GameObject triggerObject;
    public GameObject vanishItem1;
    public GameObject vanishItem2;
    public AudioClip doorSound;


    private AudioSource source;

    void Awake ()
    {
        source = GetComponent<AudioSource>();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        //        if (other.gameObject.CompareTag("Pick Up"))
        if (other.gameObject.Equals(triggerObject))
        {
            //            Debug.Log(triggerObject.name);
            //            Debug.Log("monkery eat banana");
            //            vanishItem1.transform.Rotate(new Vector3(45, 0, 0));
            source.PlayOneShot(doorSound, 1.0f);
            vanishItem1.SetActive(false);
            vanishItem2.SetActive(false);
            //            other.gameObject.SetActive(false);
            //gameObject.SetActive(false);      
            Collider selfCollider = GetComponent<Collider>();
            selfCollider.enabled = false;
                      
        
        }
    }
}
