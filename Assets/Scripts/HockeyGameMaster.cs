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

    public GameObject[] winningScreen;

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
        foreach (GameObject screen in winningScreen)
        {
            screen.SetActive(false);
        }
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
            winningScreen[0].SetActive(true);
            winScreen.SetActive(true);
            melonScore = 0;
            lemonScore = 0;
        }
        if (melonScore >= winningScore)
        {
            isWin = true;
            winningScreen[1].SetActive(true);
            winScreen.SetActive(true);
            melonScore = 0;
            lemonScore = 0;
        }
        if (rambonScore >= winningScore)
        {
            isWin = true;
            winningScreen[2].SetActive(true);
            winScreen.SetActive(true);
            melonScore = 0;
            lemonScore = 0;
        }
        if (clemonScore >= winningScore)
        {
            isWin = true;
            winningScreen[3].SetActive(true);
            winScreen.SetActive(true);
            melonScore = 0;
            lemonScore = 0;
        }
    }

}
