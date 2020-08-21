﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginUIController : MonoBehaviour
{
    public static LoginUIController instance;
    [Header("Input Field")]
    public InputField inputField;
    [Header("Pop Up Panel")]
    public GameObject popUpPanel;

    public string GetInputFieldText()
    {
        string inputFieldText = inputField.text;
        return inputFieldText;
    }

    public void SetActivePopUp(bool setActive)
    {
        popUpPanel.SetActive(setActive);
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        SetActivePopUp(false);
    }
}
