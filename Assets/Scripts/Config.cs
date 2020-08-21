using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Config
{
    public const float timeChatValue = 1.5f;
    public const float timerQuiz = 90f;

    public const string materi1_1Scene = "Materi1_1Scene";
    public const string materi1_2Scene = "Materi1_2Scene";
    public const string materi1_3Scene = "Materi1_3Scene";
    public const string materi1_4Scene = "Materi1_4Scene";
    public const string materi2_1Scene = "Materi2_1Scene";
    public const string materi2_2Scene = "Materi2_2Scene";
    public const string materi2_3Scene = "Materi2_3Scene";
    public const string materi2_4Scene = "Materi2_4Scene";
    public const string materi3_1Scene = "Materi3_1Scene";
    public const string materi3_2Scene = "Materi3_2Scene";
    public const string materi3_3Scene = "Materi3_3Scene";
    public const string materi4_1Scene = "Materi4_1Scene";
    public const string materi4_2Scene = "Materi4_2Scene";
    public const string materi4_3Scene = "Materi4_3Scene";
    public const string materi5_1Scene = "Materi5_1Scene";
    public const string materi5_2Scene = "Materi5_2Scene";
    public const string materi5_3Scene = "Materi5_3Scene";
    public const string materi6_1Scene = "Materi6_1Scene";
    public const string materi6_2Scene = "Materi6_2Scene";
    public const string materi6_3Scene = "Materi6_3Scene";
    public const string materi2Scene = "Materi2Scene";
    public const string materi3Scene = "Materi3Scene";
    public const string materi4Scene = "Materi4Scene";
    public const string materi5Scene = "Materi5Scene";
    public const string materi6Scene = "Materi6Scene";
    public const string asosiasiScene = "AsosiasiScene";
    public const string menuScene = "MenuScene";
    public const string videoScene = "VideoScene";
    public const string kuisScene = "KuisScene2";
    public const string welcomeScene = "WelcomeScene";
    public const string kdScene = "KDScene";
    public const string loginScene = "LoginScene";
    public const string profilScene = "ProfilScene";
    public const string indikatorScene = "IndikatorScene";
    public const string petunjukScene = "PetunjukScene";
    public const string halamanMenuScene = "HalamanMenuScene";
    public const string daftarPustakaScene = "DaftarPustakaScene";
    public const string subMenuScene = "SubMenuScene";
    public const string subMenu1Scene = "SubMenu1Scene";
    public const string subMenu2Scene = "SubMenu2Scene";
    public const string subMenu3Scene = "SubMenu3Scene";
    public const string subMenu4Scene = "SubMenu4Scene";
    public const string menuName1 = "Harga Jual, Harga Beli, Untung dan Rugi";
    public const string menuName2 = "Persentase Untung dan Rugi";
    public const string menuName3 = "Diskon";
    public const string menuName4 = "Pajak";
    public const string menuName5 = "Bunga Tunggal";
    public const string menuName6 = "Bruto, Netto dan Tara";
}

public class MathUtility
{
    public static int RandomizeInt(int count, List<int> listUsedValues)
    {
        int index = Random.Range(0, count);

        while (listUsedValues.Contains(index))
        {
            index = Random.Range(0, count);
        }

        listUsedValues.Add(index);
        return index;
    }

    public static int ToInteger(float inputFloat)
    {
        int outputInt = Mathf.RoundToInt(inputFloat);
        return outputInt;
    }
}

public enum CHAT_TYPE
{
    INPUT,
    OUTPUT
}

public enum ORIENTATION
{
    PORTRAIT,
    LANDSCAPE
}

public enum INPUT_FIELD_NUMBER
{
    NUMBER_1_2_1,
    NUMBER_1_2_2,
    NUMBER_1_2_3,
    NUMBER_1_2_4,
    NUMBER_1_2_5,
    NUMBER_1_3_1,
    NUMBER_1_3_2,
    NUMBER_1_3_3,
    NUMBER_1_3_4,
    NUMBER_1_3_5,
    NUMBER_1_4_1,
    NUMBER_1_4_2,
    NUMBER_1_4_3,
    NUMBER_1_4_4,
    NUMBER_2_2_1,
    NUMBER_2_2_2,
    NUMBER_2_2_3,
    NUMBER_2_2_4,
    NUMBER_2_2_5,
    NUMBER_2_3_1,
    NUMBER_2_3_2,
    NUMBER_2_3_3,
    NUMBER_2_3_4,
    NUMBER_2_3_5,
    NUMBER_3_2_1,
    NUMBER_3_2_2,
    NUMBER_3_2_3,
    NUMBER_3_2_4,
    NUMBER_3_3_1,
    NUMBER_3_3_2,
    NUMBER_3_3_3,
    NUMBER_3_3_4,
    NUMBER_4_2_1,
    NUMBER_4_2_2,
    NUMBER_4_2_3,
    NUMBER_4_2_4,
    NUMBER_4_3_1,
    NUMBER_4_3_2,
    NUMBER_4_3_3,
    NUMBER_4_3_4,
    NUMBER_4_3_5,
    NUMBER_4_3_6,
    NUMBER_5_2_1,
    NUMBER_5_2_2,
    NUMBER_5_2_3,
    NUMBER_5_2_4,
    NUMBER_5_2_5,
    NUMBER_5_3_1,
    NUMBER_5_3_2,
    NUMBER_5_3_3,
    NUMBER_5_3_4,
    NUMBER_5_3_5,
    NUMBER_6_2_1,
    NUMBER_6_2_2,
    NUMBER_6_2_3,
    NUMBER_6_2_4,
    NUMBER_6_3_1,
    NUMBER_6_3_2,
    NUMBER_6_3_3
}

public enum SCENE
{
    MATERI1_1, // Materi Chat 1 1
    MATERI1_2, // Materi Chat 1 2
    MATERI1_3, // Materi Chat 1 3
    MATERI1_4, // Materi Chat 1 4
    MATERI2_1,
    MATERI2_2,
    MATERI2_3,
    MATERI3_1,
    MATERI3_2,
    MATERI3_3,
    MATERI4_1,
    MATERI4_2,
    MATERI4_3,
    MATERI5_1,
    MATERI5_2,
    MATERI5_3,
    MATERI6_1,
    MATERI6_2,
    MATERI6_3,
    MENU,
    SUBMENU,
    VIDEO,
    ASOSIASI,
    SOAL_LATIHAN,
    LOGIN,
    KD,
    DAFTAR_PUSTAKA,
    PROFIL,
    PETUNJUK,
    HALAMAN_MENU,
    INDIKATOR,
    WELCOME
}

public enum KUIS
{
    PERTANYAAN_1,
    PERTANYAAN_2,
    PERTANYAAN_3,
    PERTANYAAN_4,
    PERTANYAAN_5,
    PERTANYAAN_6,
    PILIHAN_1,
    PILIHAN_2,
    PILIHAN_3,
    PILIHAN_4,
    PILIHAN_5,
    PILIHAN_6,
    JAWABAN_1,
    JAWABAN_2,
    JAWABAN_3,
    JAWABAN_4,
    JAWABAN_5,
    JAWABAN_6,
    PERTANYAAN_EVAL,
    PILIHAN_EVAL,
    JAWABAN_EVAL
}

public enum BUTTON_COLOR
{
    WHITE,
    GREEN,
    RED,
    YELLOW
}

public enum SOUND
{
    CORRECT,
    WRONG,
    SELECT,
    CLAP,
    NOTIFICATION
}