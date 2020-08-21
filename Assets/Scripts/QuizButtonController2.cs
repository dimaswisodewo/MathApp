using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizButtonController2 : MonoBehaviour
{
    public Text choiceText;

    public void OnChoiceButtonCLicked()
    {
        QuizController2.instance.choosenAnswer = choiceText.text;
        QuizUIController2.instance.ResetAllButtonColor();
        QuizUIController2.instance.selectedButtonImage = this.GetComponent<Image>();
        QuizUIController2.instance.SetSelectedButtonColor(BUTTON_COLOR.YELLOW);
        SoundController.instance.PlaySound(SOUND.SELECT);
        //Button thisButton = GetComponent<Button>();
        //thisButton.interactable = false;
    }
}
