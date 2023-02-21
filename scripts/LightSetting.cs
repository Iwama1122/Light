using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LightSetting : MonoBehaviour
{
    Light2D light;

    void Start()
    {
        light = GetComponent<Light2D>();
    }

    void Update()
    {
        light.color = Color.red;
    }
}
