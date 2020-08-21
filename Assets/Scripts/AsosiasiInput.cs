using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsosiasiInput : MonoBehaviour
{
    public INPUT_FIELD_NUMBER fieldNumber;
    public InputField inputField;
    public Button button;
    public AsosiasiController asosiasiController;

    public string GetInputFieldText()
    {
        string text = inputField.text;
        text = text.ToLower();
        return text;
    }

    public void OnSubmitButtonClicked()
    {
        bool isCorrect = asosiasiController.CheckAnswer(fieldNumber, GetInputFieldText());

        if (isCorrect == true)
        {
            inputField.interactable = false;
            button.interactable = false;
        }
    }
}
