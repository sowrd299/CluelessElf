using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class Playercontroller : MonoBehaviour {

    
    Animator swordattack;

    private void Start()
    {
        swordattack = gameObject.GetComponent<Animator>();
    }
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            swordattack.SetTrigger("attack");
            CameraShaker.Instance.ShakeOnce(4f,4f,.1f,1f);
        }
            

        
    }
}
