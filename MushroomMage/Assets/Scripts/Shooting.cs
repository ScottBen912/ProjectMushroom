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
    public float timer;
    [SerializeField] Transform WandEnd;
    [SerializeField] float speed = 5f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        timer = .4f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= .4f)
        {
            if (Input.GetMouseButtonDown(0))
            {
                direction = (reticle.transform.position - wand.transform.position).normalized;
                WandEnd.LookAt(reticle.transform.position);
                Shoot();
                timer = 0;
            }
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, WandEnd.transform.position, Quaternion.Euler(0f, character.transform.localEulerAngles.y, 0f));
       
    }
}
