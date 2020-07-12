using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit : MonoBehaviour
{
    

    public int speed;
    //current waypoint
    public GameObject curWP;

    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        
        direction = new Vector3(0, 0, 0);
        curWP = GameObject.FindGameObjectWithTag("Waypoint");
    }

    // Update is called once per frame
    void Update()
    {
        //move to the right at the rate of speed

        direction = curWP.transform.position - gameObject.transform.position;
        if (!(Vector3.Distance(curWP.transform.position, gameObject.transform.position) <= 1f))
        {
            direction.Normalize();
            transform.Translate(direction * speed * Time.deltaTime,Space.World);
        }
        else
        {
            Debug.Log("end");
        }
    }
}
