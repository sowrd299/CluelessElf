using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyWall : MonoBehaviour {

    public Collider2D collider;
    public Vector2 force;

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("OnCollisionEnter2D used");
        other.rigidbody.AddForce(force, ForceMode2D.Impulse);

    }

    /*void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D used");
    }*/

    // Update is called once per frame
    void Update () {
		
	}
}
