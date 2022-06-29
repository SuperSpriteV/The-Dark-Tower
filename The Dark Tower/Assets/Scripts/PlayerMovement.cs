using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerController controller;
    float horizontalmove = 0f;
    public float runspeed = 40f;
    bool jump = false;
    bool crouch=false;
    public Animator animator;



    
    // Update is called once per frame
    void Update()
    {
        horizontalmove= Input.GetAxisRaw("Horizontal")*runspeed ;

        animator.SetFloat("Speed", Mathf.Abs(horizontalmove));
            
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("Jumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;  
        }else if(Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

    }

    public void OnLanding()
    {
        animator.SetBool("Jumping",false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("Crouching", isCrouching);   
    }
    private void FixedUpdate()
    {
        controller.Move(horizontalmove*Time.fixedDeltaTime,crouch,jump);
        jump = false;
        
        


    }
}
