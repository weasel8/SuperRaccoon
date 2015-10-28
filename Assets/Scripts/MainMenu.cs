﻿using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    private float buttonWidth = 150f;
    private float buttonHeight = 30f;

    public GameObject superRaccoonLogo;

    private Vector3 superRaccoonLogoScale = new Vector3(3f, 1f, 1f);

    private Vector3 endScale = new Vector3(3.2f, 1f, 1.1f);

    private bool isLogoGrowing = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Makes the logo wiggling
	void Update () {
        if (isLogoGrowing)
        {
            if (superRaccoonLogo.transform.localScale.x <= endScale.x)
            {
                superRaccoonLogo.transform.localScale = new Vector3(superRaccoonLogo.transform.localScale.x + 0.0025f, superRaccoonLogo.transform.localScale.y, superRaccoonLogo.transform.localScale.z + 0.001f);
            }
            else
            {
                isLogoGrowing = !isLogoGrowing;
            }
        }
        else
        {
            if (superRaccoonLogo.transform.localScale.x >= superRaccoonLogoScale.x)
            {
                superRaccoonLogo.transform.localScale = new Vector3(superRaccoonLogo.transform.localScale.x - 0.0025f, superRaccoonLogo.transform.localScale.y, superRaccoonLogo.transform.localScale.z - 0.001f);
            }
            else
            {
                isLogoGrowing = !isLogoGrowing;
            }
        }
    }

    // Creates the buttons and handles the scene handling
    void OnGUI()
    {
        if (GUI.Button(new Rect((Screen.width/2) - (buttonWidth/2), 120, 150, 30), "Start"))
        {
            Debug.Log("Start game!");
            Application.LoadLevel("MainScene");
        }
        if (GUI.Button(new Rect((Screen.width / 2) - (buttonWidth / 2), 180, 150, 30), "Shop"))
        {
            Debug.Log("Go to shop");
            Application.LoadLevel("Shop");
        }
        if (GUI.Button(new Rect((Screen.width / 2) - (buttonWidth / 2), 240, 150, 30), "Credits"))
        {
            Debug.Log("Show credits");
        }
    }
}
