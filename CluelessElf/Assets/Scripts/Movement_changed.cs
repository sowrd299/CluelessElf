using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_changed : MonoBehaviour
{
    public float _speed;

    bool _defendstate;
    private Rigidbody2D rb2d;

    public float _original_speed = 20;
    public float _slow = 10;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        _speed = _original_speed;
        _defendstate = false;
    }

    void Update()
    {

        

        if (_defendstate != true){
            if (Input.GetKeyDown(KeyCode.LeftControl)){
                _speed = _slow;
                _defendstate = true;
            }
        }
        else{
            if (Input.GetKeyUp(KeyCode.LeftControl)){
                _speed = _original_speed;
                _defendstate = false;
            }

        }
    }

    void FixedUpdate()
    {

        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector2 realmovement = new Vector2(moveX, moveY);
	    realmovement.Normalize();
        rb2d.AddForce(realmovement * _speed);
    }
}
