using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    
    private float speed = 0.5F;

    private GameObject object1, object2;

    private Vector3 direction;

    //public Collider2D coll;
    // Use this for initialization
    void Start()
    {
        object1 = GameObject.Find("character");
        object2 = GameObject.Find("MOB");
        direction = transform.right;
    }


    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(object1.transform.position, object2.transform.position);
        //transform.position + transform.up + transform.right * direction.x, 0.7F);
        if (distance < 1.03F)
        {
            speed = 0;
        }
        else Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);

    }
}
