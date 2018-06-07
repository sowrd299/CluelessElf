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
    private Vector2 newspeed;
    public float fraction;
    Vector2 mdirection;
    public GameObject dashEffect;
    public AudioClip dashSFX;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
        dashCounter = 0;
        direction = false;
    }
	

	void Update () {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");


        
        if (direction == false)
        {
            mdirection = new Vector2(moveX, moveY);
            if (Input.GetKeyDown(KeyCode.LeftShift) && dashCounter < 2 && mdirection != new Vector2(0, 0))
            {
                direction = true;
                dashCounter += 1;
                Instantiate(dashEffect, transform.position, new Quaternion(180, 0, 0, 1));
                newspeed = rb.velocity;
                AudioSource.PlayClipAtPoint(dashSFX, transform.position);
            }
        }
        else
        {
            if (dashTime <= 0)
            {
                direction = false;
                dashTime = startDashTime;
                rb.velocity = newspeed + fraction * mdirection * dashspeed;
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
