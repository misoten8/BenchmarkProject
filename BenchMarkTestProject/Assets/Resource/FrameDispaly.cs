﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrameDispaly : MonoBehaviour {
    
    // Use this for initialization
    void Start()
    { 
		
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Text>().text = Time.deltaTime.ToString("f3");
        
    }
}
