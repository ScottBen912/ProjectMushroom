using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossmusic : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioBackground;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            audioSource.mute = false;
            audioSource.Play();
            audioBackground.mute = true;
        }
    }
}
    
   
