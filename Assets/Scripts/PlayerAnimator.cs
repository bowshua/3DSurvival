using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    public GameObject player;

    // Update is called once per frame
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {   
        if(Input.GetKey("w"))
        {
            animator.SetBool("isIdle", false);
            animator.SetTrigger("isRunForward");

            if(Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetTrigger("isRunForward");
                animator.SetBool("ShiftKeyDown", true);
            }
            else
            {
                animator.SetBool("ShiftKeyDown", false);
            }
        }
        else
        {
            animator.SetBool("isIdle", true);
        }

        if(Input.GetKeyDown("space"))
        {
            animator.SetTrigger("isJumping");
            animator.SetBool("ifJumping", true);
        }
        
    }
}
