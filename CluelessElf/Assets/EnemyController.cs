using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

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
        


        //test if player youches me
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Enemy bounces player back");
            CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
            other.rigidbody.AddForce(multiplier * (other.rigidbody.position - force), ForceMode2D.Impulse);

        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("OnTriggerStay2D used");

        if (other.name == "DamageArea" && Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("Enemy be attacked");
            health -= deltaHealth;
            if (health <= 0)
            {
                Debug.Log("End");
                Destroy(gameObject,.25f);
                //Destroy(GetComponent<CircleCollider2D>());
            }
        }


    }




}
