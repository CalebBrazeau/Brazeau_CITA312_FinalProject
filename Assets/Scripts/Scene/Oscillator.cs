using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    // Reference Comments.cs Line 140
    Vector3 startingPosition;
    // Reference Comments.cs Line 141
    [SerializeField] Vector3 movementVector;
    // Reference Comments.cs Line 142
    float fltMovementFactor;
    // Reference Comments.cs Line 143
    float fltPeriod;

    void Start()
    {
        // Reference Comments.cs Line 144
        fltPeriod = Random.Range(2f, 5f);
        // Reference Comments.cs Line 145
        startingPosition = transform.position;
    }

    void Update()
    {
        // Reference Comments.cs Line 146
        if (fltPeriod <= Mathf.Epsilon) { return; }

        // Reference Comments.cs Line 147
        float fltCycles = Time.time / fltPeriod;
        
        // Reference Comments.cs Line 148
        const float FLTTAU = Mathf.PI * 2;
        // Reference Comments.cs Line 149
        float fltRawSinWave = Mathf.Sin(fltCycles * FLTTAU);

        // Reference Comments.cs Line 150
        fltMovementFactor = (fltRawSinWave + 1f) / 2f;

        // Reference Comments.cs Line 151
        Vector3 offset = movementVector * fltMovementFactor;
        // Reference Comments.cs Line 152
        transform.position = startingPosition + offset;
    }
}
