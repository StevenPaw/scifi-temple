using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class ToggleFlashlight : MonoBehaviour
{
    private Light spotLight;

    private void Start()
    {
        spotLight = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            spotLight.enabled = !spotLight.enabled;
        }
    }
}
