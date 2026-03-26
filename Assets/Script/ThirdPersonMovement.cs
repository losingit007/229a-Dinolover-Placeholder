using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class ThirdPersonMovement : MonoBehaviour
{
    public float dashForce;
    public float jumpForce;
    public float maxSpeed;
    private Rigidbody rb;
    private int jumpCount;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate() {
    if (rb.linearVelocity.magnitude > maxSpeed) 
    {
        rb.linearVelocity = rb.linearVelocity.normalized * maxSpeed;
    }
}
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector3.left * dashForce,ForceMode.Impulse);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(Vector3.right * dashForce,ForceMode.Impulse);
        }
        if(Input.GetKeyDown(KeyCode.Space) && jumpCount < 1)
        {
            rb.AddForce(new Vector3 (0,1,1) * jumpForce,ForceMode.Impulse);
            jumpCount ++;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        jumpCount = 0;
    }
}
