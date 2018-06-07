using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Playercontroller : MonoBehaviour {

    
    Animator swordattack;
    public AudioClip swordSFX;

    private void Start()
    {
        swordattack = gameObject.GetComponent<Animator>();
    }
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            swordattack.SetTrigger("attack");
            AudioSource.PlayClipAtPoint(swordSFX, transform.position, 0.8f);
       
        }
            

        
    }
}
