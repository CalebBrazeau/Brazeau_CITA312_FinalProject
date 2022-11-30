using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level1Tutorial : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI acceleratePrompt;
    [SerializeField] TextMeshProUGUI brakePrompt;
    [SerializeField] TextMeshProUGUI quitPrompt;

    bool boolHasPressedW = false;
    bool boolHasPressedD = false;

    void Start()
    {
        acceleratePrompt.enabled = true;
        brakePrompt.enabled = false;
        quitPrompt.enabled = false;
    }

    void Update()
    {
        if (!boolHasPressedW && Input.GetKeyDown(KeyCode.W)) {
            boolHasPressedW = true;
            acceleratePrompt.enabled = false;
            brakePrompt.enabled = true;
        } else if (boolHasPressedW && !boolHasPressedD && Input.GetKeyDown(KeyCode.S)) {
            boolHasPressedD = true;
            brakePrompt.enabled = false;
        } else if (boolHasPressedW && boolHasPressedD) {
            quitPrompt.enabled = true;
            StartCoroutine(DestroyPrompts());
        }
    }

    IEnumerator DestroyPrompts()
    {
        while(true)
        {
            yield return new WaitForSeconds(5f);
            Destroy(brakePrompt.transform.parent.gameObject);
        }
    }
}
