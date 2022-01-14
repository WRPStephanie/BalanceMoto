using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotoControl : MonoBehaviour
{
    public WheelJoint2D right;
    public WheelJoint2D left;

    Rigidbody2D rg;

    public float speed = 1500f;
    public float rotate = 500f;

    JointMotor2D motor;

    // Start is called before the first frame update
    void Start()
    {
        motor.maxMotorTorque = 10000;
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        motor.motorSpeed = -speed * Input.GetAxis("Vertical");
        right.motor = motor;
        left.motor = motor;

        rg.AddTorque(-rotate * Input.GetAxis("Horizontal")*Time.deltaTime);
    }
}
