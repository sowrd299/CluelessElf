using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {
    Vector2 newdirection;
    Vector2 olddirection;
    float mangle;
	// Update is called once per frame
	void Update () {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        newdirection = new Vector2(moveX,moveY);
        olddirection = this.transform.position;

        mangle = Vector2.SignedAngle(olddirection, newdirection);
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(0, 0, mangle);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, mangle);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(0, 0, mangle);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(0, 0, mangle);
        }

    }
}
