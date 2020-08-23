using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsosiasiController : MonoBehaviour
{
    public AsosiasiUIController uiController;

    public bool CheckAnswer(INPUT_FIELD_NUMBER fieldNumber, string inputString)
    {
        string answerString = "kosong";
        string pembahasanString = "kosong";

        //switch (fieldNumber)
        //{
            //case INPUT_FIELD_NUMBER.ASO_1_1:
            //    answerString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_1[0];
            //    pembahasanString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_1_PEMBAHASAN[0];
            //    break;

            //case INPUT_FIELD_NUMBER.ASO_1_2:
            //    answerString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_1[1];
            //    pembahasanString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_1_PEMBAHASAN[1];
            //    break;

            //case INPUT_FIELD_NUMBER.ASO_1_3:
            //    answerString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_1[2];
            //    pembahasanString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_1_PEMBAHASAN[2];
            //    break;

            //case INPUT_FIELD_NUMBER.ASO_1_4:
            //    answerString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_1[3];
            //    pembahasanString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_1_PEMBAHASAN[3];
            //    break;

            //case INPUT_FIELD_NUMBER.ASO_2_1:
            //    answerString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_2[0];
            //    pembahasanString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_2_PEMBAHASAN[0];
            //    break;

            //case INPUT_FIELD_NUMBER.ASO_2_2:
            //    answerString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_2[1];
            //    pembahasanString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_2_PEMBAHASAN[1];
            //    break;

            //case INPUT_FIELD_NUMBER.ASO_3_1:
            //    answerString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_3[0];
            //    pembahasanString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_3_PEMBAHASAN[0];
            //    break;

            //case INPUT_FIELD_NUMBER.ASO_3_2:
            //    answerString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_3[1];
            //    pembahasanString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_3_PEMBAHASAN[1];
            //    break;

            //case INPUT_FIELD_NUMBER.ASO_4_1:
            //    answerString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_4[0];
            //    pembahasanString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_4_PEMBAHASAN[0];
            //    break;

            //case INPUT_FIELD_NUMBER.ASO_4_2:
            //    answerString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_4[1];
            //    pembahasanString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_4_PEMBAHASAN[1];
            //    break;

            //case INPUT_FIELD_NUMBER.ASO_5_1:
            //    answerString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_5[0];
            //    pembahasanString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_5_PEMBAHASAN[0];
            //    break;

            //case INPUT_FIELD_NUMBER.ASO_5_2:
            //    answerString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_5[1];
            //    pembahasanString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_5_PEMBAHASAN[1];
            //    break;

            //case INPUT_FIELD_NUMBER.ASO_6_1:
            //    answerString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_6[0];
            //    pembahasanString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_6_PEMBAHASAN[0];
            //    break;

            //case INPUT_FIELD_NUMBER.ASO_6_2:
            //    answerString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_6[1];
            //    pembahasanString = JsonData.instance.pembahasanJsonData[0].ASOSIASI_6_PEMBAHASAN[1];
            //    break;
        //}

        pembahasanString = pembahasanString.Replace("\\n", "\n");
        bool isCorrect;

        if (inputString == answerString) // if answer is correct
        {
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

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneLoader.instance.LoadScene(SCENE.SUBMENU);
        }
    }
}
