using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //player rigidbody
    public Rigidbody rbody;
    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if player is pressing a button
        Vector3 input = new Vector3
        (
            Input.GetAxis("Horizontal"),
            0.0f,
            0.0f
            //Input.GetAxis("Vertical")
        );
        
        rbody.AddForce(input * speed);
    }
}
