using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBirb : MonoBehaviour
{
    [SerializeField] GameObject birbPrefab;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float spawnTime = 2f;
    private float tempCounter = 0f;
    public int spawnAmount = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (spawnAmount >= 0 && tempCounter <= 0f)
        {
            Spawn();
            tempCounter = spawnTime;
        }
        else
        {
            tempCounter -= Time.deltaTime;
        }
    }

    void Spawn()
    {
        Instantiate(birbPrefab, spawnPoint.transform.position, Quaternion.identity);
        spawnAmount -= 1;
    }
}
