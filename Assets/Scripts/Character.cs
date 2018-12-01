using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    private float speed = 0.5F;

    private GameObject character, enemy;
    private Animator animator;
    private Vector3 direction;
    private Monster monster;
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



        monster = GetComponent<Monster>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        float distance = Vector3.Distance(character.transform.position, enemy.transform.position);
        animator.SetFloat("distance", distance);
        Debug.Log(enemy.GetComponent<Monster>().health);
        if (distance < 1.045F)
        {
            speed = 0;
            animator.SetFloat("speed", speed);
            if (Input.GetButtonDown("Fire1")) enemy.GetComponent<Monster>().ReceiveDamage();
                    

        }
        else Move();


    }


    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
        animator.SetFloat("speed", speed);
    }

    //void OnCollisionEnter2D(Collider2D col)
    //{
    //    var damageScript = col.gameObject.GetComponent<Monster>();
    //    if (Input.GetButtonDown("Fire1"))
    //        damageScript.ReceiveDamage();
    //}
}

