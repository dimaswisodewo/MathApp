using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsosiasiUIController : MonoBehaviour
{
    public List<GameObject> libraryCanvas = new List<GameObject>();
    public GameObject popUp;
    public Text popUpText;

    public void SetActivePopUp(bool setActive)
    {
        popUp.SetActive(setActive);
    }

    public void SetPopUpText(string inputString)
    {
        popUpText.text = inputString;
    }

    private void SetActiveCanvas(string menuName)
    {
        switch (menuName)
        {
            case Config.menuName1:
                libraryCanvas[0].SetActive(true);
                break;

            case Config.menuName2:
                libraryCanvas[1].SetActive(true);
                break;

            case Config.menuName3:
                libraryCanvas[2].SetActive(true);
                break;

            case Config.menuName4:
                libraryCanvas[3].SetActive(true);
                break;

            case Config.menuName5:
                libraryCanvas[4].SetActive(true);
                break;

            case Config.menuName6:
                libraryCanvas[5].SetActive(true);
                break;
        }
    }

    private void Awake()
    {
        for (int i = 0; i < libraryCanvas.Count; i++)
        {
            libraryCanvas[i].SetActive(false);
        }

        SetActiveCanvas(SceneLoader.instance.menuName);
    }
}
