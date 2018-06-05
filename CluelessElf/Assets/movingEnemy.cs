﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;


public class movingEnemy : MonoBehaviour
{

    public Collider2D collider;
    public Vector2 force;
    public int multiplier;
    public int health;
    public int deltaHealth;
    public float speed;
    public GameObject[] targ;


    //transform.position
    // Use this for initialization
    void Start()
    {
        targ = GameObject.FindGameObjectsWithTag("Player");
        force = transform.position;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("OnCollisionEnter2D used");

        //test if player youches me
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Enemy bounces player back");
            CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);

            other.rigidbody.AddForce(multiplier * (other.rigidbody.position - force), ForceMode2D.Impulse);
        }

        if (other.gameObject.tag == "Sword")
        {
            Debug.Log("Enemy be attacked");
            health -= deltaHealth;
            if (health <= 0)
            {
                Destroy(GetComponent<SpriteRenderer>());
                Destroy(GetComponent<CircleCollider2D>());
            }
        }


    }


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targ[0].transform.position, speed);
    }



}
