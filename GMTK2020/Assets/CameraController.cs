﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float h, v, movespeed;
    //float mx, my, lookspeed;
    Vector2 mz;
    float zoomspeed;

    // Start is called before the first frame update
    void Start()
    {
        h = v = 0;
        movespeed = 10;
        /*mx = my = 0;
        lookspeed = 5;*/
        transform.Rotate(new Vector3(45, -45, 0), Space.World); //40, -30 also works
        mz = Vector2.zero;
        zoomspeed = 0.7f;
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        Vector3 step = new Vector3(h, 0, v);
        movespeed = 2.5f * transform.position.y;
        transform.position += step * Time.deltaTime * movespeed;

        mz = Input.mouseScrollDelta * zoomspeed;
        Vector2 zoomstep = transform.position - (Vector3)mz;
        if(zoomstep.y >= 5 && zoomstep.y <= 12)
        {
            transform.position -= (Vector3)mz;
        }

        /*mx = Input.GetAxis("Mouse X");
        my = Input.GetAxis("Mouse Y");
        Vector3 look = new Vector3(-my, mx, 0);
        transform.Rotate(look * lookspeed, Space.Self);*/
    }
}
