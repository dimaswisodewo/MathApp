using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class JsonDownloader : MonoBehaviour
{
    public JsonData jsonData;
    private string jsonDataFileName = "PembahasanData";
    private string kuisDataFileName = "KuisData";

    public IEnumerator LoadJsonData(string _fileName)
    {
        string path = Application.streamingAssetsPath;
        string fullPath = PathCorrection(path, _fileName);
        Debug.Log("FullPath: " + fullPath);

        UnityWebRequest request = UnityWebRequest.Get(fullPath);

        yield return request.SendWebRequest();

        if (request.isHttpError || request.isNetworkError)
        {
            Debug.Log("Request Error!");
            yield break;
        }

        string downloadedText = request.downloadHandler.text;
        Debug.Log(downloadedText);

        Materi1JsonData pembahasanData = TryParseJsonData(downloadedText);
        this.jsonData.AddData(pembahasanData);
    }

    public IEnumerator LoadKuisJsonData(string _fileName)
    {
        string path = Application.streamingAssetsPath;
        string fullPath = PathCorrection(path, _fileName);
        Debug.Log("FullPath: " + fullPath);

        UnityWebRequest request = UnityWebRequest.Get(fullPath);

        yield return request.SendWebRequest();

        if (request.isHttpError || request.isNetworkError)
        {
            Debug.Log("Request Error!");
            yield break;
        }

        string downloadedText = request.downloadHandler.text;
        Debug.Log(downloadedText);

        KuisJsonData kuisData = TryParseKuisData(downloadedText);
        this.jsonData.AddKuisData(kuisData);
    }

    private string PathCorrection(string _fullPath, string _fileName)
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            _fullPath = System.IO.Path.Combine(_fullPath, _fileName + ".json");
            Debug.Log("Run in Android");
        }
        else
        {
            Debug.Log("Run in Editor");
            _fullPath = System.IO.Path.Combine("file:///" + _fullPath, _fileName + ".json");
        }

        return _fullPath;
    }

    private Materi1JsonData TryParseJsonData(string downloadedText)
    {
        Materi1JsonData data = JsonUtility.FromJson<Materi1JsonData>(downloadedText);
        return data;
    }

    private KuisJsonData TryParseKuisData(string downloadedText)
    {
        KuisJsonData data = JsonUtility.FromJson<KuisJsonData>(downloadedText);
        return data;
    }

    private IEnumerator LoadDataAtStart()
    {
        yield return StartCoroutine(LoadJsonData(jsonDataFileName));
        yield return StartCoroutine(LoadKuisJsonData(kuisDataFileName));
    }

    private IEnumerator Loader()
    {
        yield return StartCoroutine(LoadDataAtStart());
        yield return StartCoroutine(SceneLoader.instance.LoadSceneCoroutine(SCENE.LOGIN));
    }

    private void Start()
    {
        StartCoroutine(Loader());
    }
}

[System.Serializable]
public class Materi1JsonData
{
    public string[] PEMBAHASAN1_1;
    public string[] PEMBAHASAN1_2;
    public string[] PEMBAHASAN1_3;
    public string[] PEMBAHASAN1_4;
    public string[] JAWABAN_1_1;
    public string[] JAWABAN_1_2;
    public string[] JAWABAN_1_3;
    public string[] JAWABAN_1_4;
    public string[] PEMBAHASAN2_2;
    public string[] PEMBAHASAN2_3;
    public string[] JAWABAN_2_2;
    public string[] JAWABAN_2_3;
    public string[] PEMBAHASAN3_2;
    public string[] PEMBAHASAN3_3;
    public string[] JAWABAN_3_2;
    public string[] JAWABAN_3_3;
    public string[] PEMBAHASAN4_2;
    public string[] PEMBAHASAN4_3;
    public string[] JAWABAN_4_2;
    public string[] JAWABAN_4_3;
    public string[] PEMBAHASAN5_2;
    public string[] PEMBAHASAN5_3;
    public string[] JAWABAN_5_2;
    public string[] JAWABAN_5_3;
    public string[] PEMBAHASAN6_2;
    public string[] PEMBAHASAN6_3;
    public string[] JAWABAN_6_2;
    public string[] JAWABAN_6_3;
    public string[] ASOSIASI_1_PEMBAHASAN;
    public string[] ASOSIASI_2_PEMBAHASAN;
    public string[] ASOSIASI_3_PEMBAHASAN;
    public string[] ASOSIASI_4_PEMBAHASAN;
    public string[] ASOSIASI_5_PEMBAHASAN;
    public string[] ASOSIASI_6_PEMBAHASAN;
    public string[] ASOSIASI_1;
    public string[] ASOSIASI_2;
    public string[] ASOSIASI_3;
    public string[] ASOSIASI_4;
    public string[] ASOSIASI_5;
    public string[] ASOSIASI_6;

}

[System.Serializable]
public class KuisJsonData
{
    public string[] PERTANYAAN_1;
    public string[] PEMBAHASAN_1;
    public string[] PILIHAN_1_1;
    public string[] PILIHAN_1_2;
    public string[] PILIHAN_1_3;
    public string[] PILIHAN_1_4;
    public string[] PILIHAN_1_5;
    public string[] PILIHAN_1_6;
    public string[] PILIHAN_1_7;
    public string[] PILIHAN_1_8;
    public string[] PILIHAN_1_9;
    public string[] PILIHAN_1_10;
    public string[] JAWABAN_1;
    public string[] PERTANYAAN_2;
    public string[] PEMBAHASAN_2;
    public string[] PILIHAN_2_1;
    public string[] PILIHAN_2_2;
    public string[] PILIHAN_2_3;
    public string[] PILIHAN_2_4;
    public string[] PILIHAN_2_5;
    public string[] PILIHAN_2_6;
    public string[] PILIHAN_2_7;
    public string[] PILIHAN_2_8;
    public string[] PILIHAN_2_9;
    public string[] PILIHAN_2_10;
    public string[] JAWABAN_2;
    public string[] PERTANYAAN_3;
    public string[] PEMBAHASAN_3;
    public string[] PILIHAN_3_1;
    public string[] PILIHAN_3_2;
    public string[] PILIHAN_3_3;
    public string[] PILIHAN_3_4;
    public string[] PILIHAN_3_5;
    public string[] PILIHAN_3_6;
    public string[] PILIHAN_3_7;
    public string[] PILIHAN_3_8;
    public string[] PILIHAN_3_9;
    public string[] PILIHAN_3_10;
    public string[] JAWABAN_3;
    public string[] PERTANYAAN_4;
    public string[] PEMBAHASAN_4;
    public string[] PILIHAN_4_1;
    public string[] PILIHAN_4_2;
    public string[] PILIHAN_4_3;
    public string[] PILIHAN_4_4;
    public string[] PILIHAN_4_5;
    public string[] PILIHAN_4_6;
    public string[] PILIHAN_4_7;
    public string[] PILIHAN_4_8;
    public string[] PILIHAN_4_9;
    public string[] PILIHAN_4_10;
    public string[] JAWABAN_4;
    public string[] PERTANYAAN_5;
    //public string[] PEMBAHASAN_5;
    public string[] PILIHAN_5_1;
    public string[] PILIHAN_5_2;
    public string[] PILIHAN_5_3;
    public string[] PILIHAN_5_4;
    public string[] PILIHAN_5_5;
    public string[] PILIHAN_5_6;
    public string[] PILIHAN_5_7;
    public string[] PILIHAN_5_8;
    public string[] PILIHAN_5_9;
    public string[] PILIHAN_5_10;
    public string[] JAWABAN_5;
    public string[] PERTANYAAN_6;
    //public string[] PEMBAHASAN_6;
    public string[] PILIHAN_6_1;
    public string[] PILIHAN_6_2;
    public string[] PILIHAN_6_3;
    public string[] PILIHAN_6_4;
    public string[] PILIHAN_6_5;
    public string[] PILIHAN_6_6;
    public string[] PILIHAN_6_7;
    public string[] PILIHAN_6_8;
    public string[] PILIHAN_6_9;
    public string[] PILIHAN_6_10;
    public string[] JAWABAN_6;
    public string[] PERTANYAAN_EVAL;
    public string[] PILIHAN_EVAL_1;
    public string[] PILIHAN_EVAL_2;
    public string[] PILIHAN_EVAL_3;
    public string[] PILIHAN_EVAL_4;
    public string[] PILIHAN_EVAL_5;
    public string[] PILIHAN_EVAL_6;
    public string[] PILIHAN_EVAL_7;
    public string[] PILIHAN_EVAL_8;
    public string[] PILIHAN_EVAL_9;
    public string[] PILIHAN_EVAL_10;
    public string[] JAWABAN_EVAL;

}