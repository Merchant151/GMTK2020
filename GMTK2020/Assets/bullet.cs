using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Vector3 direction;
    public float speed;

    private GameObject target;
    
    public void Setup(Vector3 direction, GameObject target)
    {
        this.direction = direction;
        Destroy(gameObject, 2f);
        this.target = target;
    }       

    // Update is called once per frame
    void Update()
    {
        float range = 2f;
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
        if (Vector3.Distance(gameObject.transform.position , target.transform.position) < range)
        {
            Destroy(gameObject);
        } 
    }
}
