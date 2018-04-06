using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ZombieSound : MonoBehaviour {

    public AudioClip audioClip;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
