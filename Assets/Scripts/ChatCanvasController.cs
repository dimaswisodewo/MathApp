using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatCanvasController : MonoBehaviour
{
    public ChatCanvasUIController uiController;
    //public Text timerText;
    public List<GameObject> libraryChat = new List<GameObject>();
    public bool hasAnswered;
    private float timeChat = 0;
    private bool isTimeChatStart;
    private int numOfChatShowed = 0;

    public bool CheckAnswer(INPUT_FIELD_NUMBER fieldNumber, string inputString)
    {
        string answerString = "kosong";
        string pembahasanString = "kosong";

        switch (fieldNumber)
        {
            case INPUT_FIELD_NUMBER.NUMBER_1_2_1:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_1_2[0];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN1_2[0];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_1_2_2:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_1_2[1];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN1_2[1];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_1_2_3:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_1_2[2];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN1_2[2];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_1_2_4:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_1_2[3];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN1_2[3];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_1_2_5:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_1_2[4];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN1_2[4];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_1_3_1:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_1_3[0];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN1_3[0];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_1_3_2:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_1_3[1];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN1_3[1];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_1_3_3:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_1_3[2];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN1_3[2];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_1_3_4:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_1_3[3];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN1_3[3];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_1_3_5:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_1_3[4];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN1_3[4];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_1_4_1:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_1_4[0];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN1_4[0];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_1_4_2:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_1_4[1];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN1_4[1];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_1_4_3:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_1_4[2];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN1_4[2];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_1_4_4:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_1_4[3];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN1_4[3];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_2_2_1:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_2_2[0];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN2_2[0];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_2_2_2:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_2_2[1];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN2_2[1];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_2_2_3:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_2_2[2];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN2_2[2];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_2_2_4:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_2_2[3];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN2_2[3];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_2_2_5:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_2_2[4];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN2_2[4];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_2_3_1:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_2_3[0];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN2_3[0];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_2_3_2:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_2_3[1];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN2_3[1];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_2_3_3:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_2_3[2];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN2_3[2];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_2_3_4:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_2_3[3];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN2_3[3];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_2_3_5:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_2_3[4];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN2_3[4];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_3_2_1:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_3_2[0];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN3_2[0];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_3_2_2:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_3_2[1];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN3_2[1];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_3_2_3:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_3_2[2];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN3_2[2];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_3_2_4:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_3_2[3];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN3_2[3];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_3_3_1:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_3_3[0];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN3_3[0];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_3_3_2:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_3_3[1];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN3_3[1];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_3_3_3:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_3_3[2];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN3_3[2];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_3_3_4:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_3_3[3];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN3_3[3];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_4_2_1:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_4_2[0];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN4_2[0];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_4_2_2:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_4_2[1];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN4_2[1];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_4_2_3:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_4_2[2];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN4_2[2];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_4_2_4:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_4_2[3];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN4_2[3];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_4_3_1:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_4_3[0];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN4_3[0];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_4_3_2:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_4_3[1];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN4_3[1];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_4_3_3:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_4_3[2];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN4_3[2];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_4_3_4:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_4_3[3];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN4_3[3];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_4_3_5:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_4_3[4];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN4_3[4];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_4_3_6:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_4_3[5];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN4_3[5];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_5_2_1:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_5_2[0];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN5_2[0];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_5_2_2:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_5_2[1];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN5_2[1];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_5_2_3:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_5_2[2];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN5_2[2];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_5_2_4:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_5_2[3];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN5_2[3];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_5_2_5:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_5_2[4];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN5_2[4];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_5_3_1:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_5_3[0];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN5_3[0];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_5_3_2:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_5_3[1];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN5_3[1];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_5_3_3:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_5_3[2];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN5_3[2];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_5_3_4:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_5_3[3];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN5_3[3];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_5_3_5:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_5_3[4];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN5_3[4];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_6_2_1:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_6_2[0];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN6_2[0];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_6_2_2:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_6_2[1];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN6_2[1];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_6_2_3:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_6_2[2];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN6_2[2];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_6_2_4:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_6_2[3];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN6_2[3];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_6_3_1:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_6_3[0];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN6_3[0];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_6_3_2:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_6_3[1];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN6_3[1];
                break;

            case INPUT_FIELD_NUMBER.NUMBER_6_3_3:
                answerString = JsonData.instance.pembahasanJsonData[0].JAWABAN_6_3[2];
                pembahasanString = JsonData.instance.pembahasanJsonData[0].PEMBAHASAN6_3[2];
                break;
        }

        pembahasanString = pembahasanString.Replace("\\n", "\n");
        bool isCorrect;
        
        if (inputString == answerString) // if answer is correct
        {
            hasAnswered = true;
            isCorrect = true;
        }
        else // if wrong answer
        {
            uiController.SetPopUpText(pembahasanString);
            uiController.SetActivePopUp(true);
            isCorrect = false;
        }

        return isCorrect;
    }

    private void StartTimeChat(bool setActive)
    {
        if (setActive == true)
        {
            timeChat += Time.deltaTime;

        }
        else
        {
            timeChat = 0;
        }
    }

    private void SetActiveChat(int index, bool setActive)
    {
        libraryChat[index].SetActive(setActive);
    }

    private void Awake()
    {
        isTimeChatStart = true;
        hasAnswered = true;
    }

    private void Start()
    {
        for (int i = 0; i < libraryChat.Count; i++)
        {
            SetActiveChat(i, false);
        }
    }

    private void Update()
    {
        //timerText.text = timeChat.ToString("F0");

        if (isTimeChatStart == true)
        {
            if (timeChat <= Config.timeChatValue)
            {
                StartTimeChat(true);
            }
            else
            {
                SetActiveChat(numOfChatShowed, true);
                SoundController.instance.PlaySound(SOUND.NOTIFICATION);
                ChatCanvas chatCanvas = libraryChat[numOfChatShowed].GetComponent<ChatCanvas>();

                if (chatCanvas == null)
                {
                    hasAnswered = true;
                }
                else
                {
                    hasAnswered = false;
                }

                numOfChatShowed += 1;
                isTimeChatStart = false;
            }
        }
        else
        {
            StartTimeChat(false);
            if (numOfChatShowed < libraryChat.Count && hasAnswered == true)
            {
                isTimeChatStart = true;
            }
        }

        if (numOfChatShowed >= libraryChat.Count)
        {
            uiController.SetActiveNextButton(true);
        }
        
    }
}
