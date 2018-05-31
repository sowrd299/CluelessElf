using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour {

    Animator swordattack;

    private void Start()
    {
        swordattack = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
            swordattack.SetTrigger("attack");

    }
}
