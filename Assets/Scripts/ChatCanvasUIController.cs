using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatCanvasUIController : MonoBehaviour
{
    public GameObject popUpPanel;
    public GameObject nextButton;
    public Text popUpText;

    public void SetActivePopUp(bool setActive)
    {
        popUpPanel.SetActive(setActive);
    }

    public void SetPopUpText(string inputString)
    {
        popUpText.text = inputString;
    }

    public void SetActiveNextButton(bool setActive)
    {
        nextButton.SetActive(setActive);
    }

    private void Awake()
    {
        SetActivePopUp(false);
        SetActiveNextButton(false);
    }
}
