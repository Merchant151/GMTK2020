using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public enum Team { Ally, Enemy}
    public Team curTeam;
    public int rateOfFire;
    public bool Rotateable;
    public float range;
    private GameObject currentTarget;

    public GameObject bulletType;

    private float timeremaining;
    
    // Start is called before the first frame update
    void Start()
    {
        timeremaining = rateOfFire;
    }

    // Update is called once per frame
    void Update()
    {
        currentTarget = findNext();
        if (currentTarget != null)
        {
            if (inRange(currentTarget))
            {
                transform.LookAt(currentTarget.transform.position);
                Debug.Log("Looking at opponent at "+ currentTarget.transform.position.x +","+ currentTarget.transform.position.y);
                timeremaining -= Time.deltaTime;
                if (timeremaining <= 0)
                {
                    GameObject g = Instantiate(bulletType, gameObject.transform.position, Quaternion.identity);

                    Vector3 d = (currentTarget.transform.position - gameObject.transform.position);
                    d.Normalize();
                    g.GetComponent<bullet>().Setup(d, currentTarget);
                    timeremaining = rateOfFire;
                }

            }else
            {
                transform.LookAt(gameObject.GetComponent<EnemyUnit>().curWP.transform.position);
                Debug.Log("Opponent too far" + gameObject.GetComponent<EnemyUnit>().curWP.transform.position.x + "," + gameObject.GetComponent<EnemyUnit>().curWP.transform.position.y);
            }
        }
        else
        {
            transform.LookAt(gameObject.GetComponent<EnemyUnit>().curWP.transform.position);
            Debug.Log("Looking at waypoint");
        }
        
    }


    private bool inRange(GameObject target)
    {
        if (Vector3.Distance(target.transform.position, gameObject.transform.position) < range)
        {
            return true;
        }
        return false;
    }

    private GameObject findNext()
    {
        GameObject[] target;
        GameObject closest;
        if (curTeam == Team.Ally)
        {
            target = GameObject.FindGameObjectsWithTag("Enemy");
            if (target != null)
            {
                closest = target[0];
                float var2 = Vector3.Distance(closest.transform.position, gameObject.transform.position);
                foreach (GameObject g in target)
                {
                    if (Vector3.Distance(g.transform.position, gameObject.transform.position) < var2)
                    {
                        closest = g;
                    }
                }
                return closest;
            }
            else
                return null;
        }else
        {
            target = GameObject.FindGameObjectsWithTag("Ally");
            if (target != null)
            {
                closest = target[0];
                float var2 = Vector3.Distance(closest.transform.position, gameObject.transform.position);
                foreach (GameObject g in target)
                {
                    if (Vector3.Distance(g.transform.position, gameObject.transform.position) < var2)
                    {
                        closest = g;
                    }
                }
                return closest;
            }
            else
                return null;
        }
        
    }
}
