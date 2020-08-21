using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonData : MonoBehaviour
{
    public static JsonData instance;
    public List<Materi1JsonData> pembahasanJsonData = new List<Materi1JsonData>();
    public List<KuisJsonData> kuisJsonData = new List<KuisJsonData>();
    private string[] tempArray;

    public void AddData(Materi1JsonData _pembahasanJsonData)
    {
        pembahasanJsonData.Clear();
        pembahasanJsonData.Add(_pembahasanJsonData);
    }

    public void AddKuisData(KuisJsonData _kuisData)
    {
        kuisJsonData.Clear();
        kuisJsonData.Add(_kuisData);
    }

    public string GetQuestion(KUIS kuisEnum , int index)
    {
        string outputData = "kosong";

        switch (kuisEnum)
        {
            case KUIS.PERTANYAAN_1:
                outputData = kuisJsonData[0].PERTANYAAN_1[index];
                break;

            case KUIS.PERTANYAAN_2:
                outputData = kuisJsonData[0].PERTANYAAN_2[index];
                break;

            case KUIS.PERTANYAAN_3:
                outputData = kuisJsonData[0].PERTANYAAN_3[index];
                break;

            case KUIS.PERTANYAAN_4:
                outputData = kuisJsonData[0].PERTANYAAN_4[index];
                break;

            case KUIS.PERTANYAAN_5:
                outputData = kuisJsonData[0].PERTANYAAN_5[index];
                break;

            case KUIS.PERTANYAAN_6:
                outputData = kuisJsonData[0].PERTANYAAN_6[index];
                break;

            case KUIS.PERTANYAAN_EVAL:
                outputData = kuisJsonData[0].PERTANYAAN_EVAL[index];
                break;
        }

        return outputData;
    }

    public string GetAnswer(KUIS kuisEnum , int index)
    {
        string outputData = "kosong";

        switch (kuisEnum)
        {
            case KUIS.JAWABAN_1:
                outputData = kuisJsonData[0].JAWABAN_1[index];
                break;

            case KUIS.JAWABAN_2:
                outputData = kuisJsonData[0].JAWABAN_2[index];
                break;

            case KUIS.JAWABAN_3:
                outputData = kuisJsonData[0].JAWABAN_3[index];
                break;

            case KUIS.JAWABAN_4:
                outputData = kuisJsonData[0].JAWABAN_4[index];
                break;

            case KUIS.JAWABAN_5:
                outputData = kuisJsonData[0].JAWABAN_5[index];
                break;

            case KUIS.JAWABAN_6:
                outputData = kuisJsonData[0].JAWABAN_6[index];
                break;

            case KUIS.JAWABAN_EVAL:
                outputData = kuisJsonData[0].JAWABAN_EVAL[index];
                break;
        }

        return outputData;
    }

    public string[] GetChoice(KUIS kuisEnum, int index)
    {
        switch (kuisEnum)
        {
            case KUIS.PILIHAN_1:
                switch (index)
                {
                    case 0:
                        tempArray = kuisJsonData[0].PILIHAN_1_1;
                        break;

                    case 1:
                        tempArray = kuisJsonData[0].PILIHAN_1_2;
                        break;

                    case 2:
                        tempArray = kuisJsonData[0].PILIHAN_1_3;
                        break;

                    case 3:
                        tempArray = kuisJsonData[0].PILIHAN_1_4;
                        break;

                    case 4:
                        tempArray = kuisJsonData[0].PILIHAN_1_5;
                        break;

                    case 5:
                        tempArray = kuisJsonData[0].PILIHAN_1_6;
                        break;

                    case 6:
                        tempArray = kuisJsonData[0].PILIHAN_1_7;
                        break;

                    case 7:
                        tempArray = kuisJsonData[0].PILIHAN_1_8;
                        break;

                    case 8:
                        tempArray = kuisJsonData[0].PILIHAN_1_9;
                        break;

                    case 9:
                        tempArray = kuisJsonData[0].PILIHAN_1_10;
                        break;
                }
                break;

            case KUIS.PILIHAN_2:
                switch (index)
                {
                    case 0:
                        tempArray = kuisJsonData[0].PILIHAN_2_1;
                        break;

                    case 1:
                        tempArray = kuisJsonData[0].PILIHAN_2_2;
                        break;

                    case 2:
                        tempArray = kuisJsonData[0].PILIHAN_2_3;
                        break;

                    case 3:
                        tempArray = kuisJsonData[0].PILIHAN_2_4;
                        break;

                    case 4:
                        tempArray = kuisJsonData[0].PILIHAN_2_5;
                        break;

                    case 5:
                        tempArray = kuisJsonData[0].PILIHAN_2_6;
                        break;

                    case 6:
                        tempArray = kuisJsonData[0].PILIHAN_2_7;
                        break;

                    case 7:
                        tempArray = kuisJsonData[0].PILIHAN_2_8;
                        break;

                    case 8:
                        tempArray = kuisJsonData[0].PILIHAN_2_9;
                        break;

                    case 9:
                        tempArray = kuisJsonData[0].PILIHAN_2_10;
                        break;
                }
                break;

            case KUIS.PILIHAN_3:
                switch (index)
                {
                    case 0:
                        tempArray = kuisJsonData[0].PILIHAN_3_1;
                        break;

                    case 1:
                        tempArray = kuisJsonData[0].PILIHAN_3_2;
                        break;

                    case 2:
                        tempArray = kuisJsonData[0].PILIHAN_3_3;
                        break;

                    case 3:
                        tempArray = kuisJsonData[0].PILIHAN_3_4;
                        break;

                    case 4:
                        tempArray = kuisJsonData[0].PILIHAN_3_5;
                        break;

                    case 5:
                        tempArray = kuisJsonData[0].PILIHAN_3_6;
                        break;

                    case 6:
                        tempArray = kuisJsonData[0].PILIHAN_3_7;
                        break;

                    case 7:
                        tempArray = kuisJsonData[0].PILIHAN_3_8;
                        break;

                    case 8:
                        tempArray = kuisJsonData[0].PILIHAN_3_9;
                        break;

                    case 9:
                        tempArray = kuisJsonData[0].PILIHAN_3_10;
                        break;
                }
                break;

            case KUIS.PILIHAN_4:
                switch (index)
                {
                    case 0:
                        tempArray = kuisJsonData[0].PILIHAN_4_1;
                        break;

                    case 1:
                        tempArray = kuisJsonData[0].PILIHAN_4_2;
                        break;

                    case 2:
                        tempArray = kuisJsonData[0].PILIHAN_4_3;
                        break;

                    case 3:
                        tempArray = kuisJsonData[0].PILIHAN_4_4;
                        break;

                    case 4:
                        tempArray = kuisJsonData[0].PILIHAN_4_5;
                        break;

                    case 5:
                        tempArray = kuisJsonData[0].PILIHAN_4_6;
                        break;

                    case 6:
                        tempArray = kuisJsonData[0].PILIHAN_4_7;
                        break;

                    case 7:
                        tempArray = kuisJsonData[0].PILIHAN_4_8;
                        break;

                    case 8:
                        tempArray = kuisJsonData[0].PILIHAN_4_9;
                        break;

                    case 9:
                        tempArray = kuisJsonData[0].PILIHAN_4_10;
                        break;
                }
                break;

            case KUIS.PILIHAN_5:
                switch (index)
                {
                    case 0:
                        tempArray = kuisJsonData[0].PILIHAN_5_1;
                        break;

                    case 1:
                        tempArray = kuisJsonData[0].PILIHAN_5_2;
                        break;

                    case 2:
                        tempArray = kuisJsonData[0].PILIHAN_5_3;
                        break;

                    case 3:
                        tempArray = kuisJsonData[0].PILIHAN_5_4;
                        break;

                    case 4:
                        tempArray = kuisJsonData[0].PILIHAN_5_5;
                        break;

                    case 5:
                        tempArray = kuisJsonData[0].PILIHAN_5_6;
                        break;

                    case 6:
                        tempArray = kuisJsonData[0].PILIHAN_5_7;
                        break;

                    case 7:
                        tempArray = kuisJsonData[0].PILIHAN_5_8;
                        break;

                    case 8:
                        tempArray = kuisJsonData[0].PILIHAN_5_9;
                        break;

                    case 9:
                        tempArray = kuisJsonData[0].PILIHAN_5_10;
                        break;
                }
                break;

            case KUIS.PILIHAN_6:
                switch (index)
                {
                    case 0:
                        tempArray = kuisJsonData[0].PILIHAN_6_1;
                        break;

                    case 1:
                        tempArray = kuisJsonData[0].PILIHAN_6_2;
                        break;

                    case 2:
                        tempArray = kuisJsonData[0].PILIHAN_6_3;
                        break;

                    case 3:
                        tempArray = kuisJsonData[0].PILIHAN_6_4;
                        break;

                    case 4:
                        tempArray = kuisJsonData[0].PILIHAN_6_5;
                        break;

                    case 5:
                        tempArray = kuisJsonData[0].PILIHAN_6_6;
                        break;

                    case 6:
                        tempArray = kuisJsonData[0].PILIHAN_6_7;
                        break;

                    case 7:
                        tempArray = kuisJsonData[0].PILIHAN_6_8;
                        break;

                    case 8:
                        tempArray = kuisJsonData[0].PILIHAN_6_9;
                        break;

                    case 9:
                        tempArray = kuisJsonData[0].PILIHAN_6_10;
                        break;
                }
                break;

            case KUIS.PILIHAN_EVAL:
                switch (index)
                {
                    case 0:
                        tempArray = kuisJsonData[0].PILIHAN_EVAL_1;
                        break;

                    case 1:
                        tempArray = kuisJsonData[0].PILIHAN_EVAL_2;
                        break;

                    case 2:
                        tempArray = kuisJsonData[0].PILIHAN_EVAL_3;
                        break;

                    case 3:
                        tempArray = kuisJsonData[0].PILIHAN_EVAL_4;
                        break;

                    case 4:
                        tempArray = kuisJsonData[0].PILIHAN_EVAL_5;
                        break;

                    case 5:
                        tempArray = kuisJsonData[0].PILIHAN_EVAL_6;
                        break;

                    case 6:
                        tempArray = kuisJsonData[0].PILIHAN_EVAL_7;
                        break;

                    case 7:
                        tempArray = kuisJsonData[0].PILIHAN_EVAL_8;
                        break;

                    case 8:
                        tempArray = kuisJsonData[0].PILIHAN_EVAL_9;
                        break;

                    case 9:
                        tempArray = kuisJsonData[0].PILIHAN_EVAL_10;
                        break;
                }
                break;
        }

        return tempArray;
    }

    private void Awake()
    {
        if (instance == null)
            instance = this;

        DontDestroyOnLoad(gameObject);
    }
}
