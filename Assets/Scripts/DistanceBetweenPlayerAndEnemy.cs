using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceBetweenPlayerAndEnemy : MonoBehaviour {

    public GameObject player;
    public GameObject enemy;
    public float distance;
    public Animator anim;

    void Start () {
        anim = GetComponent<Animator>();
    }


    private void FixedUpdate () {
        distance = Vector3.Distance(player.transform.position, enemy.transform.position);
        anim.SetFloat("distance", distance);
    }

    void OnMouseDown()
    {
        anim.SetBool("Clicked", true);
    }
    void OnMouseUp()
    {
        anim.SetBool("Clicked", false);
    }
}
