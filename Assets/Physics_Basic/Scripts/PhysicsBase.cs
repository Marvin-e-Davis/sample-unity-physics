﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsBase : MonoBehaviour
{

    protected Rigidbody rb;             // rigidbody of gameobject
    public float thrust = 10f;          // amount of thrust added to direction
    [SerializeField, Range(0f, 100f)]
    public double maxVelocity = 10f;    // maximum velocity

    public Vector3 playerInput;         // input from player arrow keys

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // ~ 60 frames / second
    protected virtual void Update()
    {
        // create new Vector3 from input between -1 and 1 for x and z axis
        // update is the best place to capture Input data 
        playerInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        // normalize input (make sure vector's total length never exceeds 1)
        playerInput = Vector3.ClampMagnitude(playerInput, 1f);
    }

}
