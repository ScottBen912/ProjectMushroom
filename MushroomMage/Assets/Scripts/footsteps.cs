using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioSource footstepsSound; //sprintSound;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            //if (Input.GetKey(KeyCode.LeftShift))
            //{
            //footstepsSound.enabled = false;
            //sprintSound.enabled = true;
            //}
                footstepsSound.mute = false;
                //sprintSound.enabled = false;
            }
        else
            {
                footstepsSound.mute = true;
                //sprintSound.enabled = false;
            }
    }
}
