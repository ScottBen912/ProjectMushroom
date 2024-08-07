using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cam;
    public GameObject character;
    public Vector3 startposition;
    public void Start()
    {
        startposition = transform.position;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(transform.position + cam.forward);
        transform.position = new Vector3(character.transform.position.x, startposition.y, character.transform.position.z -2);
    }
}
