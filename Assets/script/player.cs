using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private bool jumpKeyWasPressed;
    private float horizontalmovement;
    private float depthMovement;
    private Rigidbody rigidBodyComponent;

    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody>();
    }

    void Update() 
    {
       if (Input.GetKeyDown(KeyCode.Space))
       {
           jumpKeyWasPressed = true;
       }
       horizontalmovement = Input.GetAxis("Horizontal");
       depthMovement = Input.GetAxis("Vertical");
    }
    
    private void FixedUpdate()
    {

        if(jumpKeyWasPressed)
        {
            rigidBodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }
     rigidBodyComponent.velocity = new Vector3(horizontalmovement, rigidBodyComponent.velocity.y, depthMovement);
    } 
}