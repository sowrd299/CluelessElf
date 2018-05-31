using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_ : MonoBehaviour
{

    [SerializeField]
    string _movementX;

    [SerializeField]
    string _movementY;

    [SerializeField]
    float _speed;

    bool _defendstate;

    public float _original_speed = 20;
    public float _slow = 10;

    private void Start()
    {
        _defendstate = true;
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

        float moveX = Input.GetAxis(_movementX);
        float moveY = Input.GetAxis(_movementY);
        Vector2 realmovement = new Vector2(moveX, moveY) * (Time.deltaTime * _speed);
        this.transform.Translate(realmovement, Space.World);
    }
}
