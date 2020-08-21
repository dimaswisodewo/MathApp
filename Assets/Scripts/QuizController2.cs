using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizController2 : MonoBehaviour
{
    public static QuizController2 instance;
    [HideInInspector] public string choosenAnswer;
    [HideInInspector] public bool isAnswerCorrect;
    [HideInInspector] public bool hasAnswered = false;
    [HideInInspector] public int numOfCorrectAnswer = 0;
    //[SerializeField] private List<int> usedQuestion = new List<int>();
    //[SerializeField] private List<int> usedChoice = new List<int>();
    //[SerializeField] private List<int> tempChoice = new List<int>();
    //[SerializeField] private List<int> tempQuestion = new List<int>();
    private float timeRemaining = Config.timerQuiz;
    [SerializeField] private int numOfQuestion = 0;
    public int score = 0;
    //[SerializeField] private int questionIndex;
    private bool isQuizStarting;
    [HideInInspector] public KUIS pertanyaanEnum;
    [HideInInspector] public KUIS jawabanEnum;
    [HideInInspector] public KUIS pilihanEnum;


    public void OnSubmitButtonClicked(int index)
    {
        if (numOfQuestion >= 10)
        {
            Debug.Log("Quiz Selesai...");
            QuizUIController2.instance.SetPopUpPanelActive(true);
            SoundController.instance.PlaySound(SOUND.CLAP);
            return;
        }
        else
        {
            string[] ANSWER = JsonData.instance.kuisJsonData[0].JAWABAN_1;

            switch (jawabanEnum)
            {
                case KUIS.JAWABAN_1:
                    ANSWER = JsonData.instance.kuisJsonData[0].JAWABAN_1;
                    break;

                case KUIS.JAWABAN_2:
                    ANSWER = JsonData.instance.kuisJsonData[0].JAWABAN_2;
                    break;

                case KUIS.JAWABAN_3:
                    ANSWER = JsonData.instance.kuisJsonData[0].JAWABAN_3;
                    break;

                case KUIS.JAWABAN_4:
                    ANSWER = JsonData.instance.kuisJsonData[0].JAWABAN_4;
                    break;

                case KUIS.JAWABAN_5:
                    ANSWER = JsonData.instance.kuisJsonData[0].JAWABAN_5;
                    break;

                case KUIS.JAWABAN_6:
                    ANSWER = JsonData.instance.kuisJsonData[0].JAWABAN_6;
                    break;

                case KUIS.JAWABAN_EVAL:
                    ANSWER = JsonData.instance.kuisJsonData[0].JAWABAN_EVAL;
                    break;
            }

            string answer = ANSWER[index];
            bool isCorrect = CheckAnswer(choosenAnswer, answer);
            if (isCorrect == false)
            {
                //QuizUIController2.instance.SetPopUpPanelActive(true);
                QuizUIController2.instance.libraryQuestionButton[index].image.color = new Color32(244, 91, 105, 255);
            }
            else
            {
                QuizUIController2.instance.libraryQuestionButton[index].image.color = new Color32(155, 197, 61, 255);
            }

            QuizUIController2.instance.libraryChoiceGroup[index].interactable = false;
            QuizUIController2.instance.SetActiveLibraryPopUp(index, true);
        }

        numOfQuestion += 1;
    }

    public void OnUlangiButtonClicked()
    {
        Application.LoadLevel(Application.loadedLevel);
        //usedQuestion.Clear();
        //Prepare();
        //numOfQuestion = 0;
        //numOfCorrectAnswer = 0;
        //score = 0;
        //OnSubmitButtonClicked();
        //QuizUIController.instance.SetPopUpPanelActive(false);
        //SoundController.instance.PlaySound(SOUND.SELECT);
        //OnSubmitButtonClicked();
    }

    public void OnKeluarKuisButtonClicked()
    {
        if (SceneLoader.instance.menuName == Config.halamanMenuScene)
        {
            SceneLoader.instance.LoadScene(SCENE.HALAMAN_MENU);
        }
        else
        {
            SceneLoader.instance.LoadScene(SCENE.SUBMENU);
        }
    }

    private void TimeStart(bool setActive)
    {
        if (setActive == false)
        {
            //ResetTimer();
            isQuizStarting = false;
            return;
        }

        timeRemaining -= Time.deltaTime;
        int timeRemainingInt = MathUtility.ToInteger(timeRemaining);
        QuizUIController2.instance.SetTimerText("Timer : " + timeRemaining.ToString("F0"));

        if (timeRemaining <= 0)
        {
            Debug.Log("Time is up");
            isQuizStarting = false;
        }
    }

    private bool CheckAnswer(string inputAnswer, string answer)
    {
        List<Text> libraryChoiceText = QuizUIController2.instance.libraryChoiceText1;
        List<Image> libraryChoiceButton = QuizUIController2.instance.libraryChoiceButton1;

        for (int i = 0; i < QuizUIController2.instance.libraryQuestionPanel.Count; i++)
        {
            if (QuizUIController2.instance.libraryQuestionPanel[i].activeInHierarchy)
            {
                switch (i)
                {
                    case 0:
                        libraryChoiceText = QuizUIController2.instance.libraryChoiceText1;
                        libraryChoiceButton = QuizUIController2.instance.libraryChoiceButton1;
                        break;

                    case 1:
                        libraryChoiceText = QuizUIController2.instance.libraryChoiceText2;
                        libraryChoiceButton = QuizUIController2.instance.libraryChoiceButton2;
                        break;

                    case 2:
                        libraryChoiceText = QuizUIController2.instance.libraryChoiceText3;
                        libraryChoiceButton = QuizUIController2.instance.libraryChoiceButton3;
                        break;

                    case 3:
                        libraryChoiceText = QuizUIController2.instance.libraryChoiceText4;
                        libraryChoiceButton = QuizUIController2.instance.libraryChoiceButton4;
                        break;

                    case 4:
                        libraryChoiceText = QuizUIController2.instance.libraryChoiceText5;
                        libraryChoiceButton = QuizUIController2.instance.libraryChoiceButton5;
                        break;

                    case 5:
                        libraryChoiceText = QuizUIController2.instance.libraryChoiceText6;
                        libraryChoiceButton = QuizUIController2.instance.libraryChoiceButton6;
                        break;

                    case 6:
                        libraryChoiceText = QuizUIController2.instance.libraryChoiceText7;
                        libraryChoiceButton = QuizUIController2.instance.libraryChoiceButton7;
                        break;

                    case 7:
                        libraryChoiceText = QuizUIController2.instance.libraryChoiceText8;
                        libraryChoiceButton = QuizUIController2.instance.libraryChoiceButton8;
                        break;

                    case 8:
                        libraryChoiceText = QuizUIController2.instance.libraryChoiceText9;
                        libraryChoiceButton = QuizUIController2.instance.libraryChoiceButton9;
                        break;

                    case 9:
                        libraryChoiceText = QuizUIController2.instance.libraryChoiceText10;
                        libraryChoiceButton = QuizUIController2.instance.libraryChoiceButton10;
                        break;
                }
            }
        }

        bool isCorrect;

        if (inputAnswer == answer)
        {
            isCorrect = true;
            numOfCorrectAnswer += 1;
            QuizUIController2.instance.SetSelectedButtonColor(BUTTON_COLOR.GREEN);
            //QuizUIController2.instance.SetTitleText("Jawaban Benar!");
            SoundController.instance.PlaySound(SOUND.CORRECT);
            Debug.Log("BENAR!");
        }
        else
        {
            isCorrect = false;
            QuizUIController2.instance.SetSelectedButtonColor(BUTTON_COLOR.RED);

            for (int i = 0; i < libraryChoiceText.Count; i++)
            {
                if (libraryChoiceText[i].text == answer)
                {
                    libraryChoiceButton[i].color = new Color32(155, 197, 61, 255);
                }
            }

            //QuizUIController.instance.SetTitleText("Jawaban Salah!");
            SoundController.instance.PlaySound(SOUND.WRONG);
            Debug.Log("SALAH!");
        }

        score = numOfCorrectAnswer * 10;
        Debug.Log("jawabanmu: " + inputAnswer + ", jawaban yang benar: " + answer);
        return isCorrect;
    }

    private void ResetTimer()
    {
        timeRemaining = Config.timerQuiz;
    }

    private void CheckKuisEnum()
    {
        switch (SceneLoader.instance.menuName)
        {
            case Config.menuName1:
                pertanyaanEnum = KUIS.PERTANYAAN_1;
                jawabanEnum = KUIS.JAWABAN_1;
                pilihanEnum = KUIS.PILIHAN_1;
                break;

            case Config.menuName2:
                pertanyaanEnum = KUIS.PERTANYAAN_2;
                jawabanEnum = KUIS.JAWABAN_2;
                pilihanEnum = KUIS.PILIHAN_2;
                break;

            case Config.menuName3:
                pertanyaanEnum = KUIS.PERTANYAAN_3;
                jawabanEnum = KUIS.JAWABAN_3;
                pilihanEnum = KUIS.PILIHAN_3;
                break;

            case Config.menuName4:
                pertanyaanEnum = KUIS.PERTANYAAN_4;
                jawabanEnum = KUIS.JAWABAN_4;
                pilihanEnum = KUIS.PILIHAN_4;
                break;

            case Config.menuName5:
                pertanyaanEnum = KUIS.PERTANYAAN_5;
                jawabanEnum = KUIS.JAWABAN_5;
                pilihanEnum = KUIS.PILIHAN_5;
                break;

            case Config.menuName6:
                pertanyaanEnum = KUIS.PERTANYAAN_6;
                jawabanEnum = KUIS.JAWABAN_6;
                pilihanEnum = KUIS.PILIHAN_6;
                break;

            default:
                pertanyaanEnum = KUIS.PERTANYAAN_EVAL;
                jawabanEnum = KUIS.JAWABAN_EVAL;
                pilihanEnum = KUIS.PILIHAN_EVAL;
                Debug.Log("Eval");
                break;
        }
    }

    private void Prepare()
    {
        CheckKuisEnum();
        isQuizStarting = true;
        hasAnswered = false;
        isAnswerCorrect = false;
        choosenAnswer = null;
        ResetTimer();
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

    private void Start()
    {
        Prepare();
        //hasAnswered = true;
    }

    private void Update()
    {
        if (isQuizStarting == true && hasAnswered == false)
        {
            TimeStart(true);
        }
        else
        {
            TimeStart(false);
            numOfQuestion = 10;

            for (int i = 0; i < QuizUIController2.instance.libraryPopUp.Count; i++)
            {
                QuizUIController2.instance.SetActiveLibraryPopUp(i, true);
            }

            hasAnswered = true;
        }

        if (numOfQuestion >= 10)
        {
            Debug.Log("Quiz Selesai...");
            QuizUIController2.instance.SetPopUpPanelActive(true);
            SoundController.instance.PlaySound(SOUND.CLAP);
            numOfQuestion = 0;
            ResetTimer();
        }
    }
}
