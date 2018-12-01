using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    
    private float speed = 0.35F;

    private GameObject character, enemy;
    private Animator animator;
    private Vector3 direction;

    //public Collider2D coll;
    // Use this for initialization
    private void Start()
    {
        character = GameObject.Find("character");
        enemy = GameObject.Find("MOB");
        direction = transform.right;
    }

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        float distance = Vector3.Distance(character.transform.position, enemy.transform.position);
        animator.SetFloat("distance", distance);
        Debug.Log(distance);
        if (distance < 1.045F)
        { 
            speed = 0;
            
            animator.SetFloat("speed", speed);
        }
        else Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
        animator.SetFloat("speed", speed);
    }
}

