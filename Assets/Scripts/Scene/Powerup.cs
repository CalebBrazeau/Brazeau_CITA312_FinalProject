using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    [SerializeField] string[] powerupTypes;
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
            case "Speed": // Apply affect for speed
                Debug.Log("You fast as shit boi");
            break;
            case "Jump":
                Debug.Log("Boing");
            break;
            case "That shit gripping":
                Debug.Log("That shit gripping");
            break;
            default:
                Debug.Log("EWAHHHHHHHHH");
            break;
        }
    }
}
