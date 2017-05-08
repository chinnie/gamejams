using UnityEngine;
using System.Collections;

public class catBallSFXCollision : MonoBehaviour {

    public AudioClip ballSound;

    private AudioSource source;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

 /*   IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        // Code to execute after the delay
    }
*/
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("TriggerObject"))
        {
            source.PlayOneShot(ballSound, 1.0f);

            Collider selfCollider = GetComponent<Collider>();
            selfCollider.enabled = false;

        }
//        StartCoroutine(ExecuteAfterTime(10));
//        selfCollider.enabled = true;
    }



}
