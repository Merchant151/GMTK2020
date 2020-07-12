using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", Random.Range(2, 7), Random.Range(5, 7));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        int pick = Random.Range(0, enemies.Length - 1);

        Instantiate(enemies[pick], transform);
    }
}
