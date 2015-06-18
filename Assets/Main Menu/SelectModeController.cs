﻿using UnityEngine;
using System.Collections;

public class SelectModeController : MonoBehaviour 
{
    public bool active;

    private MainMenuManager manager;

    void Start()
    {
        manager = gameObject.transform.GetComponentInParent<MainMenuManager>();
    }
	
	
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Escape)) setActive(false);
	}

    public void setActive(bool state)
    {
        if (state == true)
        {
            gameObject.SetActive(true);
            active = true;
        }
        else
        {
            gameObject.SetActive(false);
            active = false;
        }
    }

    //Buttons - Predefined
    public void buttonPreEasy()
    {
        Debug.Log("Predefined Easy button");
        manager.selectLevelPanel.setActive(true, SelectLevelController.difficult.DIFFICULT_EASY);
    }

    public void buttonPreMedium()
    {
        Debug.Log("Predefined Medium button");
        manager.selectLevelPanel.setActive(true, SelectLevelController.difficult.DIFFICULT_MEDIUM);
    }

    public void buttonPreHard()
    {
        Debug.Log("Predefined Hard button");
        manager.selectLevelPanel.setActive(true, SelectLevelController.difficult.DIFFICULT_HARD);
    }

    //Buttons - Random
    public void buttonRandEasy()
    {
        Debug.Log("Random Easy button");
    }

    public void buttonRandMedium()
    {
        Debug.Log("Random Medium button");
    }

    public void buttonRandHard()
    {
        Debug.Log("Random Hard button");
    }
}