using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ContinueButtonController : MonoBehaviour
{
    public GameObject continueButton;
    public GameObject[] objects;
    
    void Start()
    {
        // Make sure it's hidden at the start
        continueButton.SetActive(true);
    }

    // This will be called when ANY button is pressed
    public void ShowContinueButton()
    {
        continueButton.SetActive(true);

        Debug.Log ("Button active");

        if(continueButton != true)
        {
            continueButton.SetActive(true);

            Debug.Log ("Button active again!!!");
        }

        else
        {
            return;

        }

    }

}