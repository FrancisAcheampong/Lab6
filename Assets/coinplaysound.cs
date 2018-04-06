using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class coinplaysound : MonoBehaviour {

    public AudioClip clip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
       {
          GetComponent<AudioSource>().PlayOneShot(clip);
          Destroy(gameObject);
       }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        GetComponent<AudioSource>().PlayOneShot(clip);
    //        Destroy(this.gameObject);
    //    }
    //}
}
