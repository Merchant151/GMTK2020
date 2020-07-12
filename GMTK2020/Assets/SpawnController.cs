using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject[] enemies;

    //private float spawnTimer;
    private float tRemaning;
    private float multiplyer;
    // Start is called before the first frame update
    void Start()
    {
        //spawnTimer = Random.Range(2, 7);
        tRemaning = Random.Range(2,7);
        multiplyer = 1f;
        //InvokeRepeating("SpawnEnemy", Random.Range(2, 7), Random.Range(5, 7));
         
    }

    // Update is called once per frame
    void Update()
    {
        tRemaning -= Time.deltaTime;
        if (tRemaning <= 0)
        {
            SpawnEnemy();
            tRemaning = Random.Range(2, 7) / multiplyer;
        }
        if (multiplyer < 7f) multiplyer += 0.001f;
    }

    void SpawnEnemy()
    {
        int pick = Random.Range(0, enemies.Length - 1);

        Instantiate(enemies[pick], transform);
    }
}
