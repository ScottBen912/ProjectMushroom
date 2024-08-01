using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBullet : MonoBehaviour
{
    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position += transform.forward * Time.deltaTime * 20;
        transform.position = new Vector3(position.x, transform.position.y, position.z);
    }
}
