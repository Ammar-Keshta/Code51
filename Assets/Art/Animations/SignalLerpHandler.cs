// 10/8/2025 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class SignalLerpHandler : MonoBehaviour
{

    public Volume globalVolume; // اسحب هنا الـ Global Volume من الـ Inspector
    private ColorAdjustments colorAdjustments;
    public float st = 0f;
    public float et = 0f;
    public float ct = 0f;
    public float pt = 0f;

    public float pt2 = 0f;

    public float lerpDuration = 2f;
    public float lerpDurationC = 3f;
    public float lerpDurationP = 3f;

    private bool isLerping = false;
    private bool isLerping2 = false;
    private bool isLerpingC = false;
    private bool isLerpingP = false;
    private bool isLerpingP2 = false;

    private float lerpStartTime;
    private float lerpStartTime2;
    private float lerpStartTimeC;
    private float lerpStartTimeP;
    private float lerpStartTimeP2;

    public Material material1;

    public Material material2;

    public Material materialC;

    public Material materialP;

    public string parameterReference = "_Diss"; // Reference name of the Shader Graph parameter

    public string parameterReferenceC = "_Transeffect";

    public string parameterReferenceP = "_DisTir";


    private void Update()
    {


        if (material1 != null)
        {
            material1.SetFloat(parameterReference, st - et);
        }

        if (material2 != null)
        {
            material2.SetFloat(parameterReference, st - et);
        }

        if (materialC != null)
        {

            materialC.SetFloat(parameterReferenceC, ct);
        }

        if (materialP != null)
        {

            materialP.SetFloat(parameterReferenceP, pt);
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

        if (isLerpingP)
        {
            // Calculate the lerp progress
            float elapsedTimeP = Time.time - lerpStartTimeP;
            pt = Mathf.Lerp(0f, 1f, elapsedTimeP / lerpDurationP);
            Invoke("DoSomething", 4f); // بعد 3 ثواني

            // Stop lerping when the duration is reached
            if (elapsedTimeP >= lerpDurationP)
            {
                pt = 1f; // Ensure it ends exactly at 1
                isLerpingP = false;
            }
        }

        if (isLerpingP2)
        {
            // Calculate the lerp progress
            float elapsedTimeP2 = Time.time - lerpStartTimeP2;
            pt = Mathf.Lerp(1f, 0f, elapsedTimeP2 / (lerpDurationP*0.5f));

            // Stop lerping when the duration is reached
            if (elapsedTimeP2 >= (lerpDurationP*0.5f))
            {
                pt = 0f; // Ensure it ends exactly at 1
                isLerpingP = false;
            }
        }

    }


    void DoSomething()
    {
        isLerpingP2 = true;
        lerpStartTimeP2 = Time.time;
    }


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

    public void OnSignalPReceived()
    {
        isLerpingP = true;
        lerpStartTimeP = Time.time;
    }


    public void SetExposure()
    {

        // نحاول نجيب الـ ColorAdjustments من الـ VolumeProfile
        if (globalVolume.profile.TryGet<ColorAdjustments>(out colorAdjustments))
        {
            // مثال: نخلي الـ Post Exposure يساوي 1
            colorAdjustments.postExposure.value = 30f;
        }
        else
        {
            Debug.LogWarning("Color Adjustments مش موجودة في الـ Global Volume!");
        }

    }
} 

