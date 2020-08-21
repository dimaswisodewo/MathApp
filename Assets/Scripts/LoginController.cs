using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginController : MonoBehaviour
{
    public static LoginController instance;
    [Header("Input Field")]
    public InputField inputFieldName;
    public InputField inputFieldNo;
    public string profileName;
    public string profileNo;

    public string GetInputFieldText(InputField inputField)
    {
        string inputFieldText = inputField.text;
        return inputFieldText;
    }

    public void OnLoginButtonClicked()
    {
        profileName = GetInputFieldText(inputFieldName);
        profileNo = GetInputFieldText(inputFieldNo);

        if (profileName != "" && profileNo != "")
        {
            SceneLoader.instance.LoadScene(SCENE.WELCOME);
        }

    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }
}
