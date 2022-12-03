using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

[System.Serializable]
public class AxleInfo {
    // Reference Comments.cs Line 174
    public WheelCollider leftWheel;
    // Reference Comments.cs Line 175
    public WheelCollider rightWheel;
    // Reference Comments.cs Line 176
    public bool motor;
    // Reference Comments.cs Line 177
    public bool steering;
}
     
public class SimpleCarController : MonoBehaviour {
    // Reference Comments.cs Line 178
    public List<AxleInfo> axleInfos; 
    // Reference Comments.cs Line 179
    public float maxMotorTorque;
    // Reference Comments.cs Line 180
    public float maxSteeringAngle;
    
    void Update()
    {
        // Reference Comments.cs Line 181
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Reference Comments.cs Line 182
            SceneManager.LoadScene("LevelSelect");
        }
        // Reference Comments.cs Line 183
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Reference Comments.cs Line 184
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void FixedUpdate()
    {
        // Reference Comments.cs Line 185
        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        // Reference Comments.cs Line 186
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");
     
        // Reference Comments.cs Line 187
        foreach (AxleInfo axleInfo in axleInfos) {
            // Reference Comments.cs Line 188
            if (axleInfo.steering) {
                // Reference Comments.cs Line 189
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;
            }
            // Reference Comments.cs Line 190
            if (axleInfo.motor) {
                // Reference Comments.cs Line 191
                axleInfo.leftWheel.motorTorque = motor;
                axleInfo.rightWheel.motorTorque = motor;
            }
        }
    }
}