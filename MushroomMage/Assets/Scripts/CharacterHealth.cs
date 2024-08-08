using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public int amount = 1;
    public bool alive;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        alive = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Enemy")
        {
            currentHealth -= amount;
            if (currentHealth == 0)
            {
                alive = false;
                Invoke("Destroy", 0f);
            }
        }
    }
    void Destroy()
    {
        if (alive == false)
        Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
