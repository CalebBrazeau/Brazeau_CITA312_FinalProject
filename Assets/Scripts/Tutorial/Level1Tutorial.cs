using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level1Tutorial : MonoBehaviour
{
    // Reference Comments.cs Line 8
    [SerializeField] TextMeshProUGUI acceleratePrompt;
    [SerializeField] TextMeshProUGUI brakePrompt;
    [SerializeField] TextMeshProUGUI quitPrompt;

    // Reference Comments.cs Line 9
    bool boolHasPressedW = false;
    bool boolHasPressedS = false;

    void Start()
    {
        // Reference Comments.cs Line 10
        acceleratePrompt.enabled = true;
        // Reference Comments.cs Line 11
        brakePrompt.enabled = false;
        // Reference Comments.cs Line 12
        quitPrompt.enabled = false;
    }

    void Update()
    {
        // Reference Comments.cs Line 13
        if (!boolHasPressedW && Input.GetKeyDown(KeyCode.W)) {
            // Reference Comments.cs Line 14
            boolHasPressedW = true;
            // Reference Comments.cs Line 15
            acceleratePrompt.enabled = false;
            // Reference Comments.cs Line 16
            brakePrompt.enabled = true;
        // Reference Comments.cs Line 17
        } else if (boolHasPressedW && !boolHasPressedS && Input.GetKeyDown(KeyCode.S)) {
            // Reference Comments.cs Line 18
            boolHasPressedS = true;
            // Reference Comments.cs Line 19
            brakePrompt.enabled = false;
            // Reference Comments.cs Line 20
            quitPrompt.enabled = true;
        // Reference Comments.cs Line 21
        } else if (boolHasPressedW && boolHasPressedS) {
            // Reference Comments.cs Line 22
            StartCoroutine(DestroyPrompts());
        }
    }

    IEnumerator DestroyPrompts()
    {
        // Reference Comments.cs Line 23
        while(true)
        {
            // Reference Comments.cs Line 24
            yield return new WaitForSeconds(5f);
            // Reference Comments.cs Line 25
            Destroy(brakePrompt.transform.parent.gameObject);
        }
    }
}
