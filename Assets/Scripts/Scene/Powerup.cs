using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    // Reference Comments.cs Line 156
    [SerializeField] string[] powerupTypes;

    // Reference Comments.cs Line 157
    [SerializeField] string powerupType;

    void Start()
    {
        // Reference Comments.cs Line 158
        powerupType = powerupTypes[Random.Range(0, powerupTypes.Length)];
    }

    // Reference Comments.cs Line 159
    private void OnTriggerEnter(Collider other) {
        // Reference Comments.cs Line 160
        switch (powerupType)
        {
            // Reference Comments.cs Line 161
            case "Speed":
                Debug.Log("You fast as shit boi");
            break;
            // Reference Comments.cs Line 162
            case "Jump":
                Debug.Log("Boing");
            break;
            // Reference Comments.cs Line 163
            case "That shit gripping":
                Debug.Log("That shit gripping");
            break;
            // Reference Comments.cs Line 164
            default:
                Debug.Log("EWAHHHHHHHHH");
            break;
        }

        // Reference Comments.cs Line 165
        Destroy(this.gameObject);
    }
}
