using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level1Tutorial : MonoBehaviour
{
    // Reference Comments.cs Line 46
    [SerializeField] TextMeshProUGUI acceleratePrompt;
    [SerializeField] TextMeshProUGUI brakePrompt;
    [SerializeField] TextMeshProUGUI quitPrompt;

    // Reference Comments.cs Line 47
    bool boolHasPressedW = false;
    bool boolHasPressedS = false;

    void Start()
    {
        // Reference Comments.cs Line 48
        acceleratePrompt.enabled = true;
        // Reference Comments.cs Line 49
        brakePrompt.enabled = false;
        // Reference Comments.cs Line 50
        quitPrompt.enabled = false;
    }

    void Update()
    {
        // Reference Comments.cs Line 51
        if (!boolHasPressedW && Input.GetKeyDown(KeyCode.W)) {
            // Reference Comments.cs Line 52
            boolHasPressedW = true;
            // Reference Comments.cs Line 53
            acceleratePrompt.enabled = false;
            // Reference Comments.cs Line 54
            brakePrompt.enabled = true;
        // Reference Comments.cs Line 55
        } else if (boolHasPressedW && !boolHasPressedS && Input.GetKeyDown(KeyCode.S)) {
            // Reference Comments.cs Line 56
            boolHasPressedS = true;
            // Reference Comments.cs Line 57
            brakePrompt.enabled = false;
            // Reference Comments.cs Line 58
            quitPrompt.enabled = true;
        // Reference Comments.cs Line 59
        } else if (boolHasPressedW && boolHasPressedS) {
            // Reference Comments.cs Line 60
            StartCoroutine(DestroyPrompts());
        }
    }

    IEnumerator DestroyPrompts()
    {
        // Reference Comments.cs Line 61
        while(true)
        {
            // Reference Comments.cs Line 62
            yield return new WaitForSeconds(5f);
            // Reference Comments.cs Line 63
            Destroy(brakePrompt.transform.parent.gameObject);
        }
    }
}
