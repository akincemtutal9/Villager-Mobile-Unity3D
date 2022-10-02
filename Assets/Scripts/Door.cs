using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    public HingeJoint hingeJoint;
    JointMotor motor;
    public float velocity;
    public float angle;

    void Start()
    {
        motor = hingeJoint.motor;
        
    }

    // Update is called once per frame
    void Update()
    {
        angle = hingeJoint.angle;
        motor.targetVelocity = -angle;
        hingeJoint.motor = motor;

    }
}
