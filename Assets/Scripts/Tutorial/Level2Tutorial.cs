using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level2Tutorial : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI turnLeftPrompt;
    [SerializeField] TextMeshProUGUI turnRightPrompt;

    bool boolHasPressedA = false;
    bool boolHasPressedD = false;

    void Start()
    {
        turnLeftPrompt.enabled = true;
        turnRightPrompt.enabled = false;
    }

    void Update()
    {
        if (!boolHasPressedA && Input.GetKeyDown(KeyCode.A)) {
            boolHasPressedA = true;
            turnRightPrompt.enabled = true;
            turnLeftPrompt.enabled = false;
        } else if (boolHasPressedA && !boolHasPressedD && Input.GetKeyDown(KeyCode.D)) {
            boolHasPressedD = true;
        }

        if (boolHasPressedA && boolHasPressedD) {
            Destroy(turnLeftPrompt.transform.parent.gameObject);
        }
    }
}
