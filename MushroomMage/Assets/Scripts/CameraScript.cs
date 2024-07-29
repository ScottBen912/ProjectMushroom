using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject character;
    float xmove;
    float ymove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xmove -= Input.GetAxis("Mouse Y") * Time.deltaTime * -5;
        ymove += Input.GetAxis("Mouse X") * Time.deltaTime * 5;
        xmove = Mathf.Clamp(xmove, -1f, 1f);
        ymove = Mathf.Clamp(ymove, -1f, 1f);
        transform.position = new Vector3(character.transform.position.x + ymove, character.transform.position.y + xmove, -10f);
    }
}
