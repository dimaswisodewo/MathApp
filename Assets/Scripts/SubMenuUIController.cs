using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubMenuUIController : MonoBehaviour
{
    public Text menuText;

    private void SetMenuText()
    {
        menuText.text = SceneLoader.instance.menuName;
    }

    private void Awake()
    {
        SetMenuText();
    }

}
