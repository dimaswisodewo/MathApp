using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizUIController2 : MonoBehaviour
{
    public static QuizUIController2 instance;
    [Header("Text")]
    public List<Text> libraryQuestionText = new List<Text>();
    public Text titleText;
    public Text timertext;
    public Text popUpText;
    [Header("Library PopUp")]
    public List<GameObject> libraryPopUp = new List<GameObject>();
    public List<Text> libraryPopUpText = new List<Text>();
    [Header("Library Canvas Group")]
    public List<CanvasGroup> libraryChoiceGroup = new List<CanvasGroup>();
    [HideInInspector] public Image selectedButtonImage;
    [Header("Library Choice")]
    public List<Text> libraryChoiceText1 = new List<Text>();
    public List<Image> libraryChoiceButton1 = new List<Image>();
    public List<Text> libraryChoiceText2 = new List<Text>();
    public List<Image> libraryChoiceButton2 = new List<Image>();
    public List<Text> libraryChoiceText3 = new List<Text>();
    public List<Image> libraryChoiceButton3 = new List<Image>();
    public List<Text> libraryChoiceText4 = new List<Text>();
    public List<Image> libraryChoiceButton4 = new List<Image>();
    public List<Text> libraryChoiceText5 = new List<Text>();
    public List<Image> libraryChoiceButton5 = new List<Image>();
    public List<Text> libraryChoiceText6 = new List<Text>();
    public List<Image> libraryChoiceButton6 = new List<Image>();
    public List<Text> libraryChoiceText7 = new List<Text>();
    public List<Image> libraryChoiceButton7 = new List<Image>();
    public List<Text> libraryChoiceText8 = new List<Text>();
    public List<Image> libraryChoiceButton8 = new List<Image>();
    public List<Text> libraryChoiceText9 = new List<Text>();
    public List<Image> libraryChoiceButton9 = new List<Image>();
    public List<Text> libraryChoiceText10 = new List<Text>();
    public List<Image> libraryChoiceButton10 = new List<Image>();
    [Header("Game Object")]
    public GameObject popUpPanel;
    public List<GameObject> libraryQuestionPanel = new List<GameObject>();
    public List<Button> libraryQuestionButton = new List<Button>();

    public void OnQuestionButtonClicked(int index)
    {
        DeactiveAllQuestionPanel();
        SetActiveQuestionPanel(index, true);
        //SetTitleText("PERTANYAAN " + (index+1) + "/10");
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void SetActiveLibraryPopUp(int index, bool setActive)
    {
        libraryPopUp[index].SetActive(setActive);
    }

    public void SetQuestionTextOnStart()
    {
        string[] PERTANYAAN = JsonData.instance.kuisJsonData[0].PERTANYAAN_1;
        string[] PILIHAN1 = JsonData.instance.kuisJsonData[0].PILIHAN_1_1;
        string[] PILIHAN2 = JsonData.instance.kuisJsonData[0].PILIHAN_1_2;
        string[] PILIHAN3 = JsonData.instance.kuisJsonData[0].PILIHAN_1_3;
        string[] PILIHAN4 = JsonData.instance.kuisJsonData[0].PILIHAN_1_4;
        string[] PILIHAN5 = JsonData.instance.kuisJsonData[0].PILIHAN_1_5;
        string[] PILIHAN6 = JsonData.instance.kuisJsonData[0].PILIHAN_1_6;
        string[] PILIHAN7 = JsonData.instance.kuisJsonData[0].PILIHAN_1_7;
        string[] PILIHAN8 = JsonData.instance.kuisJsonData[0].PILIHAN_1_8;
        string[] PILIHAN9 = JsonData.instance.kuisJsonData[0].PILIHAN_1_9;
        string[] PILIHAN10 = JsonData.instance.kuisJsonData[0].PILIHAN_1_10;
        string[] PEMBAHASAN = JsonData.instance.kuisJsonData[0].PEMBAHASAN_1;

        switch (QuizController2.instance.pertanyaanEnum)
        {
            case KUIS.PERTANYAAN_1:
                PERTANYAAN = JsonData.instance.kuisJsonData[0].PERTANYAAN_1;
                PILIHAN1 = JsonData.instance.kuisJsonData[0].PILIHAN_1_1;
                PILIHAN2 = JsonData.instance.kuisJsonData[0].PILIHAN_1_2;
                PILIHAN3 = JsonData.instance.kuisJsonData[0].PILIHAN_1_3;
                PILIHAN4 = JsonData.instance.kuisJsonData[0].PILIHAN_1_4;
                PILIHAN5 = JsonData.instance.kuisJsonData[0].PILIHAN_1_5;
                PILIHAN6 = JsonData.instance.kuisJsonData[0].PILIHAN_1_6;
                PILIHAN7 = JsonData.instance.kuisJsonData[0].PILIHAN_1_7;
                PILIHAN8 = JsonData.instance.kuisJsonData[0].PILIHAN_1_8;
                PILIHAN9 = JsonData.instance.kuisJsonData[0].PILIHAN_1_9;
                PILIHAN10 = JsonData.instance.kuisJsonData[0].PILIHAN_1_10;
                PEMBAHASAN = JsonData.instance.kuisJsonData[0].PEMBAHASAN_1;
                break;

            case KUIS.PERTANYAAN_2:
                PERTANYAAN = JsonData.instance.kuisJsonData[0].PERTANYAAN_2;
                PILIHAN1 = JsonData.instance.kuisJsonData[0].PILIHAN_2_1;
                PILIHAN2 = JsonData.instance.kuisJsonData[0].PILIHAN_2_2;
                PILIHAN3 = JsonData.instance.kuisJsonData[0].PILIHAN_2_3;
                PILIHAN4 = JsonData.instance.kuisJsonData[0].PILIHAN_2_4;
                PILIHAN5 = JsonData.instance.kuisJsonData[0].PILIHAN_2_5;
                PILIHAN6 = JsonData.instance.kuisJsonData[0].PILIHAN_2_6;
                PILIHAN7 = JsonData.instance.kuisJsonData[0].PILIHAN_2_7;
                PILIHAN8 = JsonData.instance.kuisJsonData[0].PILIHAN_2_8;
                PILIHAN9 = JsonData.instance.kuisJsonData[0].PILIHAN_2_9;
                PILIHAN10 = JsonData.instance.kuisJsonData[0].PILIHAN_2_10;
                PEMBAHASAN = JsonData.instance.kuisJsonData[0].PEMBAHASAN_2;
                break;

            case KUIS.PERTANYAAN_3:
                PERTANYAAN = JsonData.instance.kuisJsonData[0].PERTANYAAN_3;
                PILIHAN1 = JsonData.instance.kuisJsonData[0].PILIHAN_3_1;
                PILIHAN2 = JsonData.instance.kuisJsonData[0].PILIHAN_3_2;
                PILIHAN3 = JsonData.instance.kuisJsonData[0].PILIHAN_3_3;
                PILIHAN4 = JsonData.instance.kuisJsonData[0].PILIHAN_3_4;
                PILIHAN5 = JsonData.instance.kuisJsonData[0].PILIHAN_3_5;
                PILIHAN6 = JsonData.instance.kuisJsonData[0].PILIHAN_3_6;
                PILIHAN7 = JsonData.instance.kuisJsonData[0].PILIHAN_3_7;
                PILIHAN8 = JsonData.instance.kuisJsonData[0].PILIHAN_3_8;
                PILIHAN9 = JsonData.instance.kuisJsonData[0].PILIHAN_3_9;
                PILIHAN10 = JsonData.instance.kuisJsonData[0].PILIHAN_3_10;
                PEMBAHASAN = JsonData.instance.kuisJsonData[0].PEMBAHASAN_3;
                break;

            case KUIS.PERTANYAAN_4:
                PERTANYAAN = JsonData.instance.kuisJsonData[0].PERTANYAAN_4;
                PILIHAN1 = JsonData.instance.kuisJsonData[0].PILIHAN_4_1;
                PILIHAN2 = JsonData.instance.kuisJsonData[0].PILIHAN_4_2;
                PILIHAN3 = JsonData.instance.kuisJsonData[0].PILIHAN_4_3;
                PILIHAN4 = JsonData.instance.kuisJsonData[0].PILIHAN_4_4;
                PILIHAN5 = JsonData.instance.kuisJsonData[0].PILIHAN_4_5;
                PILIHAN6 = JsonData.instance.kuisJsonData[0].PILIHAN_4_6;
                PILIHAN7 = JsonData.instance.kuisJsonData[0].PILIHAN_4_7;
                PILIHAN8 = JsonData.instance.kuisJsonData[0].PILIHAN_4_8;
                PILIHAN9 = JsonData.instance.kuisJsonData[0].PILIHAN_4_9;
                PILIHAN10 = JsonData.instance.kuisJsonData[0].PILIHAN_4_10;
                PEMBAHASAN = JsonData.instance.kuisJsonData[0].PEMBAHASAN_4;
                break;

            case KUIS.PERTANYAAN_5:
                PERTANYAAN = JsonData.instance.kuisJsonData[0].PERTANYAAN_5;
                PILIHAN1 = JsonData.instance.kuisJsonData[0].PILIHAN_5_1;
                PILIHAN2 = JsonData.instance.kuisJsonData[0].PILIHAN_5_2;
                PILIHAN3 = JsonData.instance.kuisJsonData[0].PILIHAN_5_3;
                PILIHAN4 = JsonData.instance.kuisJsonData[0].PILIHAN_5_4;
                PILIHAN5 = JsonData.instance.kuisJsonData[0].PILIHAN_5_5;
                PILIHAN6 = JsonData.instance.kuisJsonData[0].PILIHAN_5_6;
                PILIHAN7 = JsonData.instance.kuisJsonData[0].PILIHAN_5_7;
                PILIHAN8 = JsonData.instance.kuisJsonData[0].PILIHAN_5_8;
                PILIHAN9 = JsonData.instance.kuisJsonData[0].PILIHAN_5_9;
                PILIHAN10 = JsonData.instance.kuisJsonData[0].PILIHAN_5_10;
                PEMBAHASAN = JsonData.instance.kuisJsonData[0].PEMBAHASAN_5;
                break;

            case KUIS.PERTANYAAN_6:
                PERTANYAAN = JsonData.instance.kuisJsonData[0].PERTANYAAN_6;
                PILIHAN1 = JsonData.instance.kuisJsonData[0].PILIHAN_6_1;
                PILIHAN2 = JsonData.instance.kuisJsonData[0].PILIHAN_6_2;
                PILIHAN3 = JsonData.instance.kuisJsonData[0].PILIHAN_6_3;
                PILIHAN4 = JsonData.instance.kuisJsonData[0].PILIHAN_6_4;
                PILIHAN5 = JsonData.instance.kuisJsonData[0].PILIHAN_6_5;
                PILIHAN6 = JsonData.instance.kuisJsonData[0].PILIHAN_6_6;
                PILIHAN7 = JsonData.instance.kuisJsonData[0].PILIHAN_6_7;
                PILIHAN8 = JsonData.instance.kuisJsonData[0].PILIHAN_6_8;
                PILIHAN9 = JsonData.instance.kuisJsonData[0].PILIHAN_6_9;
                PILIHAN10 = JsonData.instance.kuisJsonData[0].PILIHAN_6_10;
                PEMBAHASAN = JsonData.instance.kuisJsonData[0].PEMBAHASAN_6;
                break;

            case KUIS.PERTANYAAN_EVAL:
                PERTANYAAN = JsonData.instance.kuisJsonData[0].PERTANYAAN_EVAL;
                PILIHAN1 = JsonData.instance.kuisJsonData[0].PILIHAN_EVAL_1;
                PILIHAN2 = JsonData.instance.kuisJsonData[0].PILIHAN_EVAL_2;
                PILIHAN3 = JsonData.instance.kuisJsonData[0].PILIHAN_EVAL_3;
                PILIHAN4 = JsonData.instance.kuisJsonData[0].PILIHAN_EVAL_4;
                PILIHAN5 = JsonData.instance.kuisJsonData[0].PILIHAN_EVAL_5;
                PILIHAN6 = JsonData.instance.kuisJsonData[0].PILIHAN_EVAL_6;
                PILIHAN7 = JsonData.instance.kuisJsonData[0].PILIHAN_EVAL_7;
                PILIHAN8 = JsonData.instance.kuisJsonData[0].PILIHAN_EVAL_8;
                PILIHAN9 = JsonData.instance.kuisJsonData[0].PILIHAN_EVAL_9;
                PILIHAN10 = JsonData.instance.kuisJsonData[0].PILIHAN_EVAL_10;
                PEMBAHASAN = JsonData.instance.kuisJsonData[0].PEMBAHASAN_EVAL;
                break;
        }

        for (int i = 0; i < libraryQuestionText.Count; i++)
        {
            switch (i)
            {
                case 0:
                    SetQuestionText(libraryQuestionText, i, PERTANYAAN[i]);
                    for (int j = 0; j < libraryChoiceText1.Count; j++)
                    {
                        SetChoiceText(libraryChoiceText1, j, PILIHAN1[j]);
                    }
                    SetPembahasanText(libraryPopUpText, i, PEMBAHASAN[i]);
                    break;

                case 1:
                    SetQuestionText(libraryQuestionText, i, PERTANYAAN[i]);
                    for (int j = 0; j < libraryChoiceText2.Count; j++)
                    {
                        SetChoiceText(libraryChoiceText2, j, PILIHAN2[j]);
                    }
                    SetPembahasanText(libraryPopUpText, i, PEMBAHASAN[i]);
                    break;

                case 2:
                    SetQuestionText(libraryQuestionText, i, PERTANYAAN[i]);
                    for (int j = 0; j < libraryChoiceText3.Count; j++)
                    {
                        SetChoiceText(libraryChoiceText3, j, PILIHAN3[j]);
                    }
                    SetPembahasanText(libraryPopUpText, i, PEMBAHASAN[i]);
                    break;

                case 3:
                    SetQuestionText(libraryQuestionText, i, PERTANYAAN[i]);
                    for (int j = 0; j < libraryChoiceText4.Count; j++)
                    {
                        SetChoiceText(libraryChoiceText4, j, PILIHAN4[j]);
                    }
                    SetPembahasanText(libraryPopUpText, i, PEMBAHASAN[i]);
                    break;

                case 4:
                    SetQuestionText(libraryQuestionText, i, PERTANYAAN[i]);
                    for (int j = 0; j < libraryChoiceText5.Count; j++)
                    {
                        SetChoiceText(libraryChoiceText5, j, PILIHAN5[j]);
                    }
                    SetPembahasanText(libraryPopUpText, i, PEMBAHASAN[i]);
                    break;

                case 5:
                    SetQuestionText(libraryQuestionText, i, PERTANYAAN[i]);
                    for (int j = 0; j < libraryChoiceText6.Count; j++)
                    {
                        SetChoiceText(libraryChoiceText6, j, PILIHAN6[j]);
                    }
                    SetPembahasanText(libraryPopUpText, i, PEMBAHASAN[i]);
                    break;

                case 6:
                    SetQuestionText(libraryQuestionText, i, PERTANYAAN[i]);
                    for (int j = 0; j < libraryChoiceText7.Count; j++)
                    {
                        SetChoiceText(libraryChoiceText7, j, PILIHAN7[j]);
                    }
                    SetPembahasanText(libraryPopUpText, i, PEMBAHASAN[i]);
                    break;

                case 7:
                    SetQuestionText(libraryQuestionText, i, PERTANYAAN[i]);
                    for (int j = 0; j < libraryChoiceText8.Count; j++)
                    {
                        SetChoiceText(libraryChoiceText8, j, PILIHAN8[j]);
                    }
                    SetPembahasanText(libraryPopUpText, i, PEMBAHASAN[i]);
                    break;

                case 8:
                    SetQuestionText(libraryQuestionText, i, PERTANYAAN[i]);
                    for (int j = 0; j < libraryChoiceText9.Count; j++)
                    {
                        SetChoiceText(libraryChoiceText9, j, PILIHAN9[j]);
                    }
                    SetPembahasanText(libraryPopUpText, i, PEMBAHASAN[i]);
                    break;

                case 9:
                    SetQuestionText(libraryQuestionText, i, PERTANYAAN[i]);
                    for (int j = 0; j < libraryChoiceText10.Count; j++)
                    {
                        SetChoiceText(libraryChoiceText10, j, PILIHAN10[j]);
                    }
                    SetPembahasanText(libraryPopUpText, i, PEMBAHASAN[i]);
                    break;
            }
        }
    }

    public void SetTimerText(string inputString)
    {
        SetText(timertext, inputString);
    }

    public void SetTitleText(string inputString)
    {
        SetText(titleText, inputString);
    }

    public void SetChoiceButtonInterractable(int index, bool setActive)
    {
        libraryChoiceGroup[index].interactable = setActive;
    }

    public void SetPopUpPanelActive(bool setActive)
    {
        if (setActive == true)
        {
            SetText(popUpText, "Selamat " + LoginController.instance.profileName + "! (" + LoginController.instance.profileNo + ")\n" +
                "Kamu Berhasil Menyelesaikan Kuis\ndengan Skor " + QuizController2.instance.score + "\nMenjawab " +
                QuizController2.instance.numOfCorrectAnswer + " Benar dari  10 Pertanyaan");
        }

        popUpPanel.SetActive(setActive);
    }

    public void ResetAllButtonColor()
    {
        int index = -1;
        for (int i = 0; i < libraryQuestionPanel.Count; i++)
        {
            if (libraryQuestionPanel[i].activeInHierarchy)
            {
                index = i;
                break;
            }
        }

        switch (index)
        {
            case 0:
                for (int j = 0; j < libraryChoiceButton1.Count; j++)
                {
                    SetImageColor(libraryChoiceButton1[j], BUTTON_COLOR.WHITE);
                }
                break;

            case 1:
                for (int j = 0; j < libraryChoiceButton2.Count; j++)
                {
                    SetImageColor(libraryChoiceButton2[j], BUTTON_COLOR.WHITE);
                }
                break;

            case 2:
                for (int j = 0; j < libraryChoiceButton3.Count; j++)
                {
                    SetImageColor(libraryChoiceButton3[j], BUTTON_COLOR.WHITE);
                }
                break;

            case 3:
                for (int j = 0; j < libraryChoiceButton4.Count; j++)
                {
                    SetImageColor(libraryChoiceButton4[j], BUTTON_COLOR.WHITE);
                }
                break;

            case 4:
                for (int j = 0; j < libraryChoiceButton5.Count; j++)
                {
                    SetImageColor(libraryChoiceButton5[j], BUTTON_COLOR.WHITE);
                }
                break;

            case 5:
                for (int j = 0; j < libraryChoiceButton6.Count; j++)
                {
                    SetImageColor(libraryChoiceButton6[j], BUTTON_COLOR.WHITE);
                }
                break;

            case 6:
                for (int j = 0; j < libraryChoiceButton7.Count; j++)
                {
                    SetImageColor(libraryChoiceButton7[j], BUTTON_COLOR.WHITE);
                }
                break;

            case 7:
                for (int j = 0; j < libraryChoiceButton8.Count; j++)
                {
                    SetImageColor(libraryChoiceButton8[j], BUTTON_COLOR.WHITE);
                }
                break;

            case 8:
                for (int j = 0; j < libraryChoiceButton9.Count; j++)
                {
                    SetImageColor(libraryChoiceButton9[j], BUTTON_COLOR.WHITE);
                }
                break;

            case 9:
                for (int j = 0; j < libraryChoiceButton10.Count; j++)
                {
                    SetImageColor(libraryChoiceButton10[j], BUTTON_COLOR.WHITE);
                }
                break;
        }

        selectedButtonImage = null;
    }

    public void SetSelectedButtonColor(BUTTON_COLOR inputColor)
    {
        if (selectedButtonImage != null)
        {
            SetImageColor(selectedButtonImage, inputColor);
        }
    }

    private void SetText(Text inputText, string inputString)
    {
        inputString = inputString.Replace("\\n", "\n");
        inputText.text = inputString;
    }

    private void SetQuestionText(List<Text> questionText, int index, string inputString)
    {
        questionText[index].text = inputString;
    }

    private void SetPembahasanText(List<Text> pembahasanText, int index, string inputString)
    {
        //libraryPopUpText[index].text = inputString;
        SetText(pembahasanText[index], inputString);
    }

    private void SetChoiceText(List<Text> libraryChoiceText, int index, string inputString)
    {
        SetText(libraryChoiceText[index], inputString);
    }

    private void SetImageColor(Image inputImage, BUTTON_COLOR buttonColor)
    {
        switch (buttonColor)
        {
            case BUTTON_COLOR.GREEN:
                inputImage.color = new Color32(155, 197, 61, 255);
                break;

            case BUTTON_COLOR.RED:
                inputImage.color = new Color32(244, 91, 105, 255);
                break;

            case BUTTON_COLOR.YELLOW:
                inputImage.color = new Color32(246, 205, 97, 255);
                break;

            case BUTTON_COLOR.WHITE:
                inputImage.color = new Color32(50, 130, 184, 255);
                break;
        }
    }

    //private string ManageText(string InText)
    //{
    //    int CIndex = InText.IndexOf("\\n"); // Gets the Index of yur "\n" Char
    //    InText = InText.Remove(CIndex, 2); // Removes "\n from original String"
    //    InText = InText.Insert(CIndex, "\n"); // Adds the actual New Line symbol
    //    return InText;
    //}

    private void DeactiveAllQuestionPanel()
    {
        for (int i = 0; i < libraryQuestionPanel.Count; i++)
        {
            SetActiveQuestionPanel(i, false);
        }
    }

    private void SetActiveQuestionPanel(int index, bool setActive)
    {
        libraryQuestionPanel[index].SetActive(setActive);
        SetTitleText("PERTANYAAN " + (index + 1) + "/10");
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        SetPopUpPanelActive(false);
    }

    private void Start()
    {
        DeactiveAllQuestionPanel();
        SetActiveQuestionPanel(0, true);
        SetQuestionTextOnStart();
    }
}
