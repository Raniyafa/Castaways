using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement5 : MonoBehaviour
{
    static Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();

    }


    void Update()
    {

        if (Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("isJumping");
        }
    }
}

