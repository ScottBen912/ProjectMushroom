using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    public Transform Player;
    public int MoveSpeed = 4;
    public int MaxDist = 10;
    public int MinDist = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

            //if (Vector3.Distance(transform.position, Player.position) <= Dist)
            //{

            //}
        }
    }
}
