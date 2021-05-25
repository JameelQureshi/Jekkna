using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplashScreen : MonoBehaviour
{

    //public GameObject fadeScreen;

    //public void Start()
    //{
    //    fadeScreen.GetComponent<Animation>().Play("");
    //}

    private CanvasGroup fadeGroup;
    private float fadeInSpeed = 0.33f;
    private Vector3 desiredMenuPosition;

    private void Start()
    {
        // Grab the only CanvasGroup is the scene
        fadeGroup = FindObjectOfType<CanvasGroup>();

        //Start with a light blue screen
        fadeGroup.alpha = 1;

        // Add button on-click events to customize buttons
        InitCustomize();

    }

    private void Update()
    {
        // Fade-in
        fadeGroup.alpha = 1 - Time.timeSinceLevelLoad * fadeInSpeed;
    }

    private void InitCustomize()
    {

    }



    private void NavigateTo(int menuIndex)
    {
        switch (menuIndex)
        {
            // 0 && default case = Main Menu 
            default:
            case 0:
                desiredMenuPosition = Vector3.zero;
                break;
            // 1 = Play
            case 1:
                desiredMenuPosition = Vector3.right * 1334;
                break;
            // 2 = Customize Menu
            case 2:
                desiredMenuPosition = Vector3.left * 1334;
                break;
        }
    }



    //Buttons
    public void OnPlayClick()
    {
        NavigateTo(1);
        Debug.Log("Play button has been clicked!");

    }


    public void OnCustomizeClick()
    {
        NavigateTo(2);
        Debug.Log("Customize button has been clicked!");
    }


    public void OnBackClick()
    {
        NavigateTo(0);
        Debug.Log("Back button has been clicked!");
    }


    private void OnColorSelect(int currentIndex)
    {
        Debug.Log("Selecting color button : " + currentIndex);
    }

    public void OnColorBuySet()
    {
        Debug.Log("Buy/Set color");
    }


}
