// 10/8/2025 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using System;
using UnityEditor;
using UnityEngine;

public class SignalLerpHandler : MonoBehaviour
{
    public float st = 0f;
    public float et = 0f;
    public float ct = 0f;
    public float lerpDuration = 2f;

    public float lerpDurationC = 3f;
    private bool isLerping = false;
    private bool isLerping2 = false;
    private bool isLerpingC = false;
    private float lerpStartTime;
    private float lerpStartTime2;
    private float lerpStartTimeC;

    public Material material1; // First material using the Shader Graph

    public Material material2; // Second material using the Shader Graph

    public Material materialC; // First material using the Shader Graph

    public string parameterReference = "_Diss"; // Reference name of the Shader Graph parameter

    public string parameterReferenceC = "_Transeffect"; // Reference name of the Shader Graph parameter


    private void Update()
    {


        if (material1 != null)
        {
            // Update the Shader Graph parameter for the first material
            material1.SetFloat(parameterReference, st - et);
        }

        if (material2 != null)
        {
            // Update the Shader Graph parameter for the second material
            material2.SetFloat(parameterReference, st - et);
        }

        if (materialC != null)
        {
            // Update the Shader Graph parameter for the second material
            materialC.SetFloat(parameterReferenceC, ct);
        }

        if (isLerping)
        {
            // Calculate the lerp progress
            float elapsedTime = Time.time - lerpStartTime;
            st = Mathf.Lerp(0f, 1f, elapsedTime / lerpDuration);


            // Stop lerping when the duration is reached
            if (elapsedTime >= lerpDuration)
            {
                st = 1f; // Ensure it ends exactly at 1
                isLerping = false;
            }
        }

        if (isLerping2)
        {
            // Calculate the lerp progress
            float elapsedTime2 = Time.time - lerpStartTime2;
            et = Mathf.Lerp(0f, 1f, elapsedTime2 / lerpDuration);


            // Stop lerping when the duration is reached
            if (elapsedTime2 >= lerpDuration)
            {
                et = 1f; // Ensure it ends exactly at 1
                isLerping2 = false;
            }
        }

        if (isLerpingC)
        {
            // Calculate the lerp progress
            float elapsedTimeC = Time.time - lerpStartTimeC;
            ct = Mathf.Lerp(0f, 1f, elapsedTimeC / lerpDurationC);


            // Stop lerping when the duration is reached
            if (elapsedTimeC >= lerpDurationC)
            {
                ct = 1f; // Ensure it ends exactly at 1
                isLerpingC = false;
            }
        }

    }

    // This method will be called when the signal is triggered
    public void OnSignalReceived()
    {
        isLerping = true;
        lerpStartTime = Time.time;
    }

    public void OnSignal2Received()
    {
        isLerping2 = true;
        lerpStartTime2 = Time.time;
    }

    public void OnSignalCReceived()
    {
        isLerpingC = true;
        lerpStartTimeC = Time.time;
    }


} 

