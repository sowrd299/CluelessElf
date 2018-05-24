using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMovement : MonoBehaviour {

    private Rigidbody2D rb;
    public float dashspeed;
    private float dashTime;
    public float startDashTime;
    private bool direction;
    public int dashCounter;
    public float timer;
    Vector2 mdirection;


    void Start () {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
        dashCounter = 0;
    }
	

	void Update () {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        if (true) {
            if (direction == false)
            {
                if (Input.GetKeyDown(KeyCode.LeftShift) && dashCounter < 3)
                {
                    direction = true;
                    dashCounter += 1;
                    mdirection = new Vector2(moveX, moveY);
                }
            }
            else
            {
                if (dashTime <= 0)
                {
                    direction = false;
                    dashTime = startDashTime;
                    rb.velocity = Vector2.zero;
                }
                else
                {
                    dashTime -= Time.deltaTime;

                    if (direction == true)
                    {
                        rb.velocity = mdirection * dashspeed;
                    }
                }
            }
        }


        
    }


    void FixedUpdate()
    {
        if (dashCounter >= 1)
        {
            if (timer >= 3)
            {
                timer = 0;
                dashCounter -= 1;
            }
            else
            {
                timer += 0.02f;
            }
        }
    }
}
