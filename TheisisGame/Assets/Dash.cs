using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using System.Collections;
using System;

public class Dash : MonoBehaviour
{

    public float speed;
    private Rigidbody rb;
    public float MaxDashTime = 1.0f;
    public float dashSpeed = 1.0f;
    public float dashStoppingSpeed = 0.1f;
    private float currentDashTime;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentDashTime = MaxDashTime;

    }


    void dash()
    {
        transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        rb.AddForce(transform.forward * speed, ForceMode.VelocityChange);

    }


    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {

            if (Input.GetKeyDown(KeyCode.Q))
            {
                currentDashTime = 0.0f;
            }
            if (currentDashTime < MaxDashTime)
            {
                dash();
                currentDashTime += dashStoppingSpeed;
            }

        }

    }

}