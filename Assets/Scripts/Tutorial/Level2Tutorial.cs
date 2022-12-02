using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level2Tutorial : MonoBehaviour
{
    // Reference Comments.cs Line 66
    [SerializeField] TextMeshProUGUI turnLeftPrompt;
    [SerializeField] TextMeshProUGUI turnRightPrompt;

    // Reference Comments.cs Line 67
    bool boolHasPressedA = false;
    bool boolHasPressedD = false;

    void Start()
    {
        // Reference Comments.cs Line 68
        turnLeftPrompt.enabled = true;
        // Reference Comments.cs Line 69
        turnRightPrompt.enabled = false;
    }

    void Update()
    {
        // Reference Comments.cs Line 70
        if (!boolHasPressedA && Input.GetKeyDown(KeyCode.A)) {
            // Reference Comments.cs Line 71
            boolHasPressedA = true;
            // Reference Comments.cs Line 72
            turnRightPrompt.enabled = true;
            // Reference Comments.cs Line 73
            turnLeftPrompt.enabled = false;
        // Reference Comments.cs Line 74
        } else if (boolHasPressedA && !boolHasPressedD && Input.GetKeyDown(KeyCode.D)) {
            // Reference Comments.cs Line 75
            boolHasPressedD = true;
        }
        // Reference Comments.cs Line 76
        if (boolHasPressedA && boolHasPressedD) {
            // Reference Comments.cs Line 77
            Destroy(turnLeftPrompt.transform.parent.gameObject);
        }
    }
}
