using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

[System.Serializable]
public class AxleInfo {
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor;
    public bool steering;
}
     
public class SimpleCarController : MonoBehaviour {
    public List<AxleInfo> axleInfos; 
    public float maxMotorTorque;
    public float maxSteeringAngle;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("LevelSelect");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void FixedUpdate()
    {
        // Get vertical input for forward/backward movement
        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        // Get horizontal input for turning movement
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");
     
        // Pretty self explanitory
        foreach (AxleInfo axleInfo in axleInfos) {
            // If there is steering input
            if (axleInfo.steering) {
                // Apply steering angle to both wheels
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;
            }
            // If there is motor input
            if (axleInfo.motor) {
                // Apply torque to both wheels
                axleInfo.leftWheel.motorTorque = motor;
                axleInfo.rightWheel.motorTorque = motor;
            }
        }
    }
}