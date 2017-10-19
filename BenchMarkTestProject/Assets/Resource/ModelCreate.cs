using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelCreate : MonoBehaviour {

    public GameObject target;
    static public InputField InputNum;
    public int CreateNum;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void modelcreate(InputField inputfield)
    {
        GameObject[] tagobjs = GameObject.FindGameObjectsWithTag("Model");
        foreach (GameObject obj in tagobjs)
        {
            Destroy(obj);
        }
        InputNum = inputfield;
        CreateNum = Convert.ToInt32(InputNum.text);
        if (CreateNum < 1) CreateNum = 1; 
        //折り返しの数値作成
        float R = CreateNum;
        int cnt = 0;
        int Return=0;
        while ((int)R > 1)
        {
            R = R / 2;
            cnt++;
        }
        cnt = cnt + 2;
        //生成数に応じて生成場所を変える
        for (int i = 0; i < CreateNum; i++)
        {
            if (i % cnt == 0 && i != 0)
            {
                Return++;
            }
            Instantiate(target, new Vector3(1.0f * (i%cnt), -2.4976f, (float)Return ), Quaternion.identity);
        }
    }
    
}
