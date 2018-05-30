using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public Collider2D collider;
    public Vector2 force;
    public int multiplier;
    public int health;
    public int deltaHealth;
    //transform.position
    // Use this for initialization
    void Start()
    {
        force = transform.position;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("OnCollisionEnter2D used");

        //test if player youches me
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Enemy bounces player back");
            other.rigidbody.AddForce(multiplier * (other.rigidbody.position - force), ForceMode2D.Impulse);
            health -= deltaHealth;
            if(health <= 0)
            {
                Destroy(GetComponent<SpriteRenderer>());
                Destroy(GetComponent<CircleCollider2D>());
            }
        }


    }

    /*void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D used");
    }*/

    // Update is called once per frame
    void Update()
    {

    }



}
