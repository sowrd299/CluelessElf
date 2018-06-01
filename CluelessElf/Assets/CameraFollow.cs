﻿using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;

    public float smoothspeed = 0.125f;
    public Vector3 offset;
    void FixedUpdate()
    {
        Vector3 deiredPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, deiredPosition, smoothspeed);
        transform.position = smoothPosition;

    }


}
