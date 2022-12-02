using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level1Tutorial : MonoBehaviour
{
<<<<<<< HEAD
    // Reference Comments.cs Line 8
=======
    // Reference Comments.cs Line 46
>>>>>>> f23fbcf3656a2f243993647a3248d56a458e4e55
    [SerializeField] TextMeshProUGUI acceleratePrompt;
    [SerializeField] TextMeshProUGUI brakePrompt;
    [SerializeField] TextMeshProUGUI quitPrompt;

<<<<<<< HEAD
    // Reference Comments.cs Line 9
=======
    // Reference Comments.cs Line 47
>>>>>>> f23fbcf3656a2f243993647a3248d56a458e4e55
    bool boolHasPressedW = false;
    bool boolHasPressedS = false;

    void Start()
    {
<<<<<<< HEAD
        // Reference Comments.cs Line 10
        acceleratePrompt.enabled = true;
        // Reference Comments.cs Line 11
        brakePrompt.enabled = false;
        // Reference Comments.cs Line 12
=======
        // Reference Comments.cs Line 48
        acceleratePrompt.enabled = true;
        // Reference Comments.cs Line 49
        brakePrompt.enabled = false;
        // Reference Comments.cs Line 50
>>>>>>> f23fbcf3656a2f243993647a3248d56a458e4e55
        quitPrompt.enabled = false;
    }

    void Update()
    {
<<<<<<< HEAD
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
=======
        // Reference Comments.cs Line 51
        if (!boolHasPressedW && Input.GetKeyDown(KeyCode.W)) {
            // Reference Comments.cs Line 52
            boolHasPressedW = true;
            // Reference Comments.cs Line 53
            acceleratePrompt.enabled = false;
            // Reference Comments.cs Line 54
            brakePrompt.enabled = true;
        // Reference Comments.cs Line 55
        } else if (boolHasPressedW && !boolHasPressedD && Input.GetKeyDown(KeyCode.S)) {
            // Reference Comments.cs Line 56
            boolHasPressedD = true;
            // Reference Comments.cs Line 57
            brakePrompt.enabled = false;
            // Reference Comments.cs Line 58
            quitPrompt.enabled = true;
        // Reference Comments.cs Line 59
        } else if (boolHasPressedW && boolHasPressedD) {
            // Reference Comments.cs Line 60
>>>>>>> f23fbcf3656a2f243993647a3248d56a458e4e55
            StartCoroutine(DestroyPrompts());
        }
    }

    IEnumerator DestroyPrompts()
    {
<<<<<<< HEAD
        // Reference Comments.cs Line 23
        while(true)
        {
            // Reference Comments.cs Line 24
            yield return new WaitForSeconds(5f);
            // Reference Comments.cs Line 25
=======
        // Reference Comments.cs Line 61
        while(true)
        {
            // Reference Comments.cs Line 62
            yield return new WaitForSeconds(5f);
            // Reference Comments.cs Line 63
>>>>>>> f23fbcf3656a2f243993647a3248d56a458e4e55
            Destroy(brakePrompt.transform.parent.gameObject);
        }
    }
}
