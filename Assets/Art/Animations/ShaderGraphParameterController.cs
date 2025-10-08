// 10/8/2025 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using System;
using UnityEditor;
using UnityEngine;

public class ShaderGraphParameterController : MonoBehaviour
{
    public Material material1; // First material using the Shader Graph
    public Material material2; // Second material using the Shader Graph
    public string parameterReference = "_Diss"; // Reference name of the Shader Graph parameter
    public float targetValue = 1f; // Target value for the shader parameter

    private void Update()
    {
        if (material1 != null)
        {
            // Update the Shader Graph parameter for the first material
            material1.SetFloat(parameterReference, targetValue);
        }

        if (material2 != null)
        {
            // Update the Shader Graph parameter for the second material
            material2.SetFloat(parameterReference, targetValue);
        }
    }
}
