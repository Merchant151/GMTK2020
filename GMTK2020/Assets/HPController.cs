using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPController : MonoBehaviour
{
    public int hp;

    // Start is called before the first frame update
    void Start()
    {
        hp = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnCollisionStay(Collision collision)
    {
        Destroy(collision.gameObject);
    }*/
}
