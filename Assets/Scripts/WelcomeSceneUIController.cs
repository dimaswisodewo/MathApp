using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WelcomeSceneUIController : MonoBehaviour
{
    public Text welcomeText;

    public void SetWelcomeText(string inputStringName, string inputStringNo)
    {
        welcomeText.text = "Halo " + inputStringName + "!" + " (" + inputStringNo + ")";
    }

    private void Awake()
    {
        SetWelcomeText(LoginController.instance.profileName, LoginController.instance.profileNo);
    }
}
