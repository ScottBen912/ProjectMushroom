using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMusic : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip BossMusic1, defaultMusic; 


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
