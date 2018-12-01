using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {
    [SerializeField]
    public int health = 5;
    bool dmgtaken = false;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        
    }

    public void ReceiveDamage()
    {
        dmgtaken = true;
        health--;
        if (health == 0) Die();
        animator.SetBool("dmgtaken", dmgtaken);
        
       // dmgtaken = false;
       // animator.SetBool("dmgtaken", dmgtaken);
    }

    protected void Die()
    {
        animator.SetBool("isDead", true);
        Destroy(gameObject, 1.5F);

    }
}
