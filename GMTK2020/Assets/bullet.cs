using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Vector3 direction;
    public float speed;

    private GameObject target;

    public int damage;
    
    public void Setup(Vector3 direction, GameObject target)
    {
        this.direction = direction;
        Destroy(gameObject, 2f);
        this.target = target;
    }       

    // Update is called once per frame
    void Update()
    {
        direction = Vector3.Scale(direction , new Vector3(1,1,0));
        float range = 0.5f;
        transform.Translate(direction * speed * Time.deltaTime , Space.World);
        if (target != null)
        {
            if (Vector3.Distance(gameObject.transform.position, target.transform.position) < range)
            {
                Debug.Log("hit target:"+target.name);
                target.GetComponent<unitStats>().doDam(damage);
                Destroy(gameObject);
            }
        }
    }
}
