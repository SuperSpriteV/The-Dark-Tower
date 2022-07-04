using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    public Rigidbody2D playerRigidBody2D;
    public Animator animator;
    public bool fallen;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerRigidBody2D.velocity.y < -2){
            animator.SetBool("Falling",true);
        } else {
            animator.SetBool("Falling",false);
        }
    }
}
