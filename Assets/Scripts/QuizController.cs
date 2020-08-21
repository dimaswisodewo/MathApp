using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizController : MonoBehaviour
{
    public static QuizController instance;
    [HideInInspector] public string choosenAnswer;
    [HideInInspector] public bool isAnswerCorrect;
    [HideInInspector] public bool hasAnswered;
    [HideInInspector] public int numOfCorrectAnswer = 0;
    [SerializeField] private List<int> usedQuestion = new List<int>();
    [SerializeField] private List<int> usedChoice = new List<int>();
    [SerializeField] private List<int> tempChoice = new List<int>();
    [SerializeField] private List<int> tempQuestion = new List<int>();
    private float timeRemaining = Config.timerQuiz;
    private int numOfQuestion = 0;
    public int score = 0;
    [SerializeField] private int questionIndex;
    private bool isQuizStarting;
    private KUIS pertanyaanEnum;
    private KUIS jawabanEnum;
    private KUIS pilihanEnum;


    public void OnSubmitButtonClicked()
    {
        NextQuestion();
    }

    public void OnUlangiButtonClicked()
    {
        usedQuestion.Clear();
        Prepare();
        numOfQuestion = 0;
        numOfCorrectAnswer = 0;
        score = 0;
        OnSubmitButtonClicked();
        QuizUIController.instance.SetPopUpPanelActive(false);
        SoundController.instance.PlaySound(SOUND.SELECT);
        OnSubmitButtonClicked();
    }

    public void OnKeluarKuisButtonClicked()
    {
        //SoundController.instance.PlaySound(SOUND.SELECT);
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
            ResetTimer();
            isQuizStarting = false;
            return;
        }

        timeRemaining -= Time.deltaTime;
        int timeRemainingInt = MathUtility.ToInteger(timeRemaining);
        QuizUIController.instance.SetTimerText("Timer : " + timeRemaining.ToString("F0"));

        if (timeRemaining <= 0)
        {
            Debug.Log("Time is up");
            NextQuestion();
            isQuizStarting = false;
        }
    }

    private void NextQuestion()
    {
        if (hasAnswered == true)
        {
            numOfQuestion += 1;

            if (numOfQuestion > 10)
            {
                //PlayerPrefs.SetInt("ValidScore", score);
                Debug.Log("Quiz Selesai...");
                QuizUIController.instance.SetPopUpPanelActive(true);
                SoundController.instance.PlaySound(SOUND.CLAP);
                return;
            }

            QuizUIController.instance.SetTitleText("Pertanyaan " + numOfQuestion + "/" + JsonData.instance.kuisJsonData[0].PERTANYAAN_1.Length);
            QuizUIController.instance.SetSubmitText("Kirim Jawaban");
            QuizUIController.instance.SetQuestionText(GetRandomQuestion());
            SetMultipleChoice(questionIndex);
            Prepare();
            QuizUIController.instance.SetChoiceButtonInterractable(true);
            QuizUIController.instance.ResetAllButtonColor();
            //SoundController.instance.PlaySound(SOUND.SELECT);
        }
        else
        {
            Debug.Log(choosenAnswer);
            isAnswerCorrect = CheckAnswer(choosenAnswer);
            hasAnswered = true;
            QuizUIController.instance.SetSubmitText("Lanjutkan");
            QuizUIController.instance.SetChoiceButtonInterractable(false);
        }
    }

    private bool CheckAnswer(string inputAnswer)
    {
        string answer = JsonData.instance.GetAnswer(jawabanEnum, questionIndex);
        Debug.Log("Get answer " + questionIndex);
        bool isCorrect;

        if (inputAnswer == answer)
        {
            isCorrect = true;
            numOfCorrectAnswer += 1;
            QuizUIController.instance.SetSelectedButtonColor(BUTTON_COLOR.GREEN);
            QuizUIController.instance.SetTitleText("Jawaban Benar!");
            SoundController.instance.PlaySound(SOUND.CORRECT);
            Debug.Log("BENAR!");
        }
        else
        {
            isCorrect = false;
            QuizUIController.instance.SetSelectedButtonColor(BUTTON_COLOR.RED);

            for (int i = 0; i < QuizUIController.instance.libraryChoiceText.Count; i++)
            {
                if (QuizUIController.instance.libraryChoiceText[i].text == answer)
                {
                    QuizUIController.instance.libraryChoiceButton[i].color = new Color32(155, 197, 61, 255);
                }
            }

            QuizUIController.instance.SetTitleText("Jawaban Salah!");
            SoundController.instance.PlaySound(SOUND.WRONG);
            Debug.Log("SALAH!");
        }

        score = numOfCorrectAnswer * 10;
        //QuizUIController.instance.SetScoreText("Skor: " + score);
        //QuizUIController.instance.SetQuestionText(JsonData.instance.kuisJsonData[0].EXPLANATION[questionIndex]);
        Debug.Log("jawabanmu: " + inputAnswer + ", jawaban yang benar: " + answer);
        return isCorrect;
    }

    private string GetRandomQuestion()
    {
        questionIndex = MathUtility.RandomizeInt(JsonData.instance.kuisJsonData[0].PERTANYAAN_1.Length, tempQuestion);

        while (usedQuestion.Contains(questionIndex))
        {
            questionIndex = MathUtility.RandomizeInt(JsonData.instance.kuisJsonData[0].PERTANYAAN_1.Length, tempQuestion);
        }

        usedQuestion.Add(questionIndex);
        tempQuestion.Clear();
        string outputString = JsonData.instance.GetQuestion(pertanyaanEnum, questionIndex);
        Debug.Log("Get question " + questionIndex);
        return outputString;
    }

    private void SetMultipleChoice(int index)
    {
        string[] choiceArray = JsonData.instance.GetChoice(pilihanEnum, index);

        for (int i = 0; i < choiceArray.Length; i++)
        {
            int random = MathUtility.RandomizeInt(QuizUIController.instance.libraryChoiceText.Count, tempChoice);

            while (usedChoice.Contains(random))
            {
                random = MathUtility.RandomizeInt(QuizUIController.instance.libraryChoiceText.Count, tempChoice);
            }

            QuizUIController.instance.SetChoiceText(random, choiceArray[i]);
            usedChoice.Add(random);
        }

        tempChoice.Clear();
        usedChoice.Clear();
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
        hasAnswered = true;
        NextQuestion();
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
        }
    }
}
