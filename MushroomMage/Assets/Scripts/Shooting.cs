using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform WandEnd;
    [SerializeField] float speed = 5f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        rb.velocity = new Vector3(0f, 0f, 3f) * speed;
        Instantiate(bulletPrefab, WandEnd.transform.position, Quaternion.identity);
       
    }
}
