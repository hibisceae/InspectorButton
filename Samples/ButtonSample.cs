using UnityEngine;
using InspectorButton;
using System;

public class ButtonSample : MonoBehaviour 
{
    [InspectorButton("Sample")]
    private void SampleMethod()
    {
        Debug.Log("Hi from sample method!");
    }

    [InspectorButton("Sample With Parameter", 10)]
    private void SampleWithParameter(Int32 number)
    {
        Debug.Log($"Hi from sample method, parameter {number}");
    }
}
