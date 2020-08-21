using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatCanvas : MonoBehaviour
{
    public INPUT_FIELD_NUMBER fieldNumber;
    public InputField inputField;
    public Button button;
    public ChatCanvasController chatController;

    public string GetInputFieldText()
    {
        string text = inputField.text;
        text = text.ToLower();
        return text;
    }

    public void OnSubmitButtonClicked()
    {
        bool isCorrect = chatController.CheckAnswer(fieldNumber, GetInputFieldText());

        if (isCorrect == true)
        {
            inputField.interactable = false;
            button.interactable = false;
            SoundController.instance.PlaySound(SOUND.CORRECT);
        }
        else
        {
            SoundController.instance.PlaySound(SOUND.WRONG);
        }
    }
}
