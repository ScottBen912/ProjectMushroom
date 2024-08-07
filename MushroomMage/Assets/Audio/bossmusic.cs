using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossmusic : MonoBehaviour
{
    public AudioSource audioSource;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wizard" && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
    
   
