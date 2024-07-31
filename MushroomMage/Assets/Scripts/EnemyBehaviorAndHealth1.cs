using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviorAndHealth1 : MonoBehaviour
{

    public int maxHealth = 3;
    public int currentHealth;
    public int amount = 1;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter (Collision collision)
    {
        if (collision.collider.gameObject.tag == "Bullet")
        {
            currentHealth -= amount;
            if (currentHealth == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
