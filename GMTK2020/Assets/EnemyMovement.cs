using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    GameObject[] goals;
    float movespeed;
    GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        goals = GameObject.FindGameObjectsWithTag("PlayerHP");
        int aim = Random.Range(0, goals.Length - 1);
        target = goals[aim];
        transform.LookAt(target.transform);
        movespeed = 0.02f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * movespeed;

        Collider[] inrange = Physics.OverlapSphere(transform.position, 0.2f);
        foreach(Collider checking in inrange)
        {
            if (checking.tag == "PlayerHP") Destroy(gameObject);
        }
        /*Vector3 step = transform.forward * movespeed;
        if (transform.position + step == target.transform.position)
        {

        }*/
    }
}
