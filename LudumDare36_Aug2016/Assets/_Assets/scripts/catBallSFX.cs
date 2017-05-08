using UnityEngine;
using System.Collections;

public class catBallSFX : MonoBehaviour {

    public AudioClip ballSound;

    private AudioSource source;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
            source.PlayOneShot(ballSound, 1.0f);
    }
}
