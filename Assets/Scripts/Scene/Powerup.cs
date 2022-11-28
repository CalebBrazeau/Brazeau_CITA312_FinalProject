using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    // Variable that stores the different types of powerups
    [SerializeField] string[] powerupTypes;

    // Variable to store the objects powerup type
    [SerializeField] string powerupType;

    // Start is called before the first frame update
    void Start()
    {
        // Choose powerup from powerup array
        powerupType = powerupTypes[Random.Range(0, powerupTypes.Length)];
    }

    // On collision apply affect
    private void OnTriggerEnter(Collider other) {
        switch (powerupType)
        {
            // Apply speed powerup
            case "Speed":
                Debug.Log("You fast as shit boi");
            break;
            // Apply jump powerup
            case "Jump":
                Debug.Log("Boing");
            break;
            // Apply grip powerup
            case "That shit gripping":
                Debug.Log("That shit gripping");
            break;
            // Default to nothing so it does not break
            default:
                Debug.Log("EWAHHHHHHHHH");
            break;
        }
    }
}
