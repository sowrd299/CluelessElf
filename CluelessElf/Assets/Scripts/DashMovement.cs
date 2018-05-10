using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMovement : MonoBehaviour {

    private Rigidbody2D rb;
    public float dashspeed;
    private float dashTime;
    public float startDashTime;
    private int direction;
    public int dashCounter;
    public float timer;


	void Start () {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
        dashCounter = 0;

    }
	

	void Update () {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector2 mdirection = new Vector2(moveX, moveY);




        if (dashCounter <= 3) {
            if (direction == 0)
            {
                if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    direction = 1;
                    dashCounter += 1;
                }
            }
            else
            {
                if (dashTime <= 0)
                {
                    direction = 0;
                    dashTime = startDashTime;
                    rb.velocity = Vector2.zero;
                }
                else
                {
                    dashTime -= Time.deltaTime;

                    if (direction == 1)
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
