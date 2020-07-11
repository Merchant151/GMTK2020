using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float h, v, movespeed;

    // Start is called before the first frame update
    void Start()
    {
        h = v = 0;
        movespeed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 step = new Vector3(h, v, 0);

        transform.position += step * Time.deltaTime * movespeed;
    }
}
