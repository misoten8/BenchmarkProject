using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// FPS,Betweenframes Display
/// </summary>
public class FPSDebug : MonoBehaviour {

    int frameCount;
    float prevTime;
    float display;

    void Start()
    {
        frameCount = 0;
        prevTime = 0.0f;
    }

    void Update()
    {
        ++frameCount;
        float time = Time.realtimeSinceStartup - prevTime;
        display = frameCount / time;
        if (time >= 0.5f)
        {
            //Put FPS in the attached text component
            this.GetComponent<Text>().text = display.ToString("f3") + " FPS";
            frameCount = 0;
            prevTime = Time.realtimeSinceStartup;
        }
    }
}
