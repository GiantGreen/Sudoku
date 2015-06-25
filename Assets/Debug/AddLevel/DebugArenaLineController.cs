﻿using UnityEngine;
using System.Collections;

public class DebugArenaLineController : MonoBehaviour 
{
    public DebugAreaController[] area;


	// Use this for initialization
	void Awake () 
    {
        area = new DebugAreaController[9];

        for(int i = 0; i < 9; ++i)
        {
            area[i] = gameObject.transform.GetChild(i).gameObject.GetComponent<DebugAreaController>();
        }
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}