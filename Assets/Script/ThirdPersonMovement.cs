using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class ThirdPersonMovement : MonoBehaviour
{
    public float dashForce;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.forward * dashForce,ForceMode.Impulse);
        }
    }
}
