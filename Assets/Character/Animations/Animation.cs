using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class animationStateController : MonoBehaviour
{​​
Animator animator;
    int isWalkingHash;
    int isRunninHash;




    // Start is called before the first frame update
    void Start()
    {​​
animator = GetComponent<Animator>();



        // increase performance
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunninHash = Animator.StringToHash("isRunning");

    }​​



// Update is called once per frame
void Update()
    {​​
bool isRunning = animator.GetBool(isRunninHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");




        //if player presses w key
        if (!isWalking && forwardPressed)
        {​​
// then set the isWalking boolean to be true
animator.SetBool(isWalkingHash, true);
        }​​



// if player is not pressing w key
if (isWalking && !forwardPressed)
        {​​
// then set the isWalking boolean to be false
animator.SetBool(isWalkingHash, false);
        }​​



// if player is walking and presses left shift
if (forwardPressed && runPressed)
        {​​
// then set the isRunning boolean to be true
animator.SetBool(isRunninHash, true);
        }​​



// if player stops running or stops walking
if (!forwardPressed || !runPressed)
        {​​
// then set the isRunning boolean to be false
animator.SetBool(isRunninHash, false);
        }​​




}​​



}​​