using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.tag == "Enemy")
        {
            DestroyBullet();
        }
    }

    void DestroyBullet()
    {
        Destroy(this.gameObject);
    }

}
