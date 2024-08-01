using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    public GameObject reticle;
    public GameObject wand;
    public GameObject character;
    public Vector3 direction;
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
            direction = (reticle.transform.position - wand.transform.position).normalized;
            WandEnd.LookAt(reticle.transform.position);
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, WandEnd.transform.position, Quaternion.Euler(0f, character.transform.localEulerAngles.y, 0f));
       
    }
}
