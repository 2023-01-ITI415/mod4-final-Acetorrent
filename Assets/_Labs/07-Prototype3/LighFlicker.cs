using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LighFlicker : MonoBehaviour
{
    private float originalIntensity;
    private float flickerIntensity;
    private float timer;

    void Start()
    {
        originalIntensity = GetComponent<Light>().intensity;
        flickerIntensity = originalIntensity;
        timer = 0f;
    }

    void Update()
    {
        // Set the light's intensity to flicker randomly
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            flickerIntensity = Random.Range(0f, 2f) * originalIntensity;
            timer = Random.Range(0.05f, 0.5f);
        }

        // Smoothly interpolate the light's intensity between its original value and its flicker value
        float lerp = Mathf.PingPong(Time.time, timer) / timer;
        GetComponent<Light>().intensity = Mathf.Lerp(originalIntensity, flickerIntensity, lerp);
    }
}
