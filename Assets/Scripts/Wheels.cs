using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheels : MonoBehaviour
{
    //https://www.youtube.com/watch?v=QQs9MWLU_tU
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider backLeft;

    [SerializeField] Transform frontRightTrans;
    [SerializeField] Transform frontLeftTrans;
    [SerializeField] Transform backRightTrans;
    [SerializeField] Transform backLeftTrans;

    public float acceleration = 500f;
    public float brakingForce = 300f;
    public float maxTurnAngle = 30f;

    private float currentAcc = 0f;
    private float currentBrakeF = 0f;
    private float currentTurnAngle = 0f;

    private void FixedUpdate()
    {
        currentAcc = acceleration * Input.GetAxis("Vertical");

        //the space is the brake
        if (Input.GetKey(KeyCode.Space))
            currentBrakeF = brakingForce;
        else
            currentBrakeF = 0f;

        //a front-wheel drive car
        frontRight.motorTorque = currentAcc;
        frontLeft.motorTorque = currentAcc;

        //the brake applies to all four wheels
        frontRight.brakeTorque = currentBrakeF;
        frontLeft.brakeTorque = currentBrakeF;
        backRight.brakeTorque = currentBrakeF;
        backLeft.brakeTorque = currentBrakeF;

        //steering the wheels
        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;

        UpdateWheel(frontRight, frontRightTrans);
        UpdateWheel(frontLeft, frontLeftTrans);
        UpdateWheel(backRight, backRightTrans);
        UpdateWheel(backLeft, backLeftTrans);
        

    }
  
//turning the wheel
  void UpdateWheel(WheelCollider col, Transform transf)
    {
        Vector3 position;
        Quaternion rotation;
        col.GetWorldPose(out position, out rotation);

        transf.position = position;
        transf.rotation = rotation;
    }

}
