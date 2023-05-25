using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HockeyGameMaster : MonoBehaviour
{

    private AudioSource asource;

    public static GameObject BGMinstance;
    public GameObject BGM;

    public static int lemonScore = 0;
    public GameObject[] lemonMice;
    public static int melonScore = 0;
    public GameObject[] melonMice;
    public static int rambonScore = 0;
    public GameObject[] rambonMice;
    public static int clemonScore = 0;
    public GameObject[] clemonMice;

    public static bool isWin = false;

    public float pointVisibility;

    public int winningScore;

    public GameObject winScreen;

    public TextMeshProUGUI winnerText;

    public float speedModification = 1;

    void Awake()
    {
        Time.timeScale = speedModification;

        if (BGMinstance == null)
        {
            BGMinstance = BGM;
            DontDestroyOnLoad(BGMinstance);
        }
        else Destroy(BGM);
    }

    void Start()
    {
        asource = GetComponent<AudioSource>();
        winScreen.SetActive(false);
    }
    void Update()
    {

        for (int i = 0; i < lemonScore; i++)
        {
            lemonMice[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, pointVisibility);
        }

        for (int i = 0; i < melonScore; i++)
        {
            melonMice[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, pointVisibility);
        }

        for (int i = 0; i < rambonScore; i++)
        {
            rambonMice[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, pointVisibility);
        }

        for (int i = 0; i < clemonScore; i++)
        {
            clemonMice[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, pointVisibility);
        }

        if (lemonScore >= winningScore)
        {
            isWin = true;
            Time.timeScale = 0;
            winScreen.SetActive(true);
            winnerText.text = "Lemon Wins !\nPress 'R' to reset";
            melonScore = 0;
            lemonScore = 0;
        }
        if (melonScore >= winningScore)
        {
            isWin = true;
            Time.timeScale = 0;
            winScreen.SetActive(true);
            winnerText.text = "Melon Wins !\nPress 'R' to reset";
            melonScore = 0;
            lemonScore = 0;
        }
        if (rambonScore >= winningScore)
        {
            isWin = true;
            Time.timeScale = 0;
            winScreen.SetActive(true);
            winnerText.text = "Rambon Wins !\nPress 'R' to reset";
            melonScore = 0;
            lemonScore = 0;
        }
        if (clemonScore >= winningScore)
        {
            isWin = true;
            Time.timeScale = 0;
            winScreen.SetActive(true);
            winnerText.text = "Clemon Wins !\nPress 'R' to reset";
            melonScore = 0;
            lemonScore = 0;
        }
    }

}
