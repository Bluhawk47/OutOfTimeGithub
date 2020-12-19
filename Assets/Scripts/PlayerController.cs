using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Animator playerAnimator;

    //this variable will be ignored for some reason if created under 'CharacterController'
    private float gravity = -20;
    
    //player controls
    public CharacterController controller;
    private Vector3 direction;

    //increase speed
    private float speed = 8;

    //increase jump hight
    private float jumpHight = 10;
    //check if player is grounded
    public Transform groundCheck;
    //to know what is ground 
    public LayerMask groundLayer;

    //double jump
    //private bool canDoubleJump = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if player is dead
        if(PlayerHealth.gameOver == true)
        {
            //disable this script
            this.enabled = false;

        }

        //when player presses left/right or a/d
        float pInput = Input.GetAxis("Horizontal");
        direction.x = pInput * speed;

        //checks to see ifGrounded is true before jump is able for use
        //                                      position,           radius, layerMask(any objects layer set to 'ground' can be considered isGround = true)
        bool isGrounded = Physics.CheckSphere(groundCheck.position, 0.15f, groundLayer);
        
        //if player/sphere is grounded
        if (isGrounded)
        {
            //reset to true when player lands so that they can double jump again
            //canDoubleJump = true;

            //when player presses space bar
            if (Input.GetButtonDown("Jump"))
            {
                playerAnimator.SetTrigger("jump");
                //jump
                direction.y = jumpHight;
            }

        }
        else
        {
            //adds gravity
            direction.y += gravity * Time.deltaTime;

            //if player wants to double jump
            //if (canDoubleJump && Input.GetButtonDown("Jump"))
            //{
            //    //double jump
            //    direction.y = jumpHight;
            //    //so that player cant jump more that two times
            //    canDoubleJump = false;
            //}
        }


        //part of movement
        playerAnimator.SetBool("isMoving",  direction.x != 0);
        controller.Move(direction * Time.deltaTime);

        ////to help keep z at 0
        //if(transform.position.z != 0)
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        //}
    }
}
