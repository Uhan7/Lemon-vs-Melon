using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameMaster : MonoBehaviour
{

    private AudioSource asource;
    public static GameObject BGM;

    public static int lemonScore = 0;
    public GameObject[] lemonPoints;
    public static int melonScore = 0;
    public GameObject[] melonPoints;

    public float pointVisibility;

    public int winningScore;

    public GameObject winScreen;

    public TextMeshProUGUI winnerText;

    public float speedModification = 1;

    void Awake()
    {
        Time.timeScale = speedModification;
    }

    void Start()
    {
        asource = GetComponent<AudioSource>();
        winScreen.SetActive(false);
    }
    void Update()
    {

        switch (lemonScore)
        {
            case 1:
                lemonPoints[0].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, pointVisibility);
                break;

            case 2:
                for (int i = 0; i < 2; i++)
                {
                    lemonPoints[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, pointVisibility);
                }
                break;

            case 3:
                for (int i = 0; i < 3; i++)
                {
                    lemonPoints[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, pointVisibility);
                }
                break;

            case 4:
                for (int i = 0; i < 4; i++)
                {
                    lemonPoints[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, pointVisibility);
                }
                break;

            case 5:
                for (int i = 0; i < 5; i++)
                {
                    lemonPoints[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, pointVisibility);
                }
                break;

            default:
                break;
        }

        switch (melonScore)
        {
            case 1:
                melonPoints[0].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, pointVisibility);
                break;

            case 2:
                for (int i = 0; i < 2; i++)
                {
                    melonPoints[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, pointVisibility);
                }
                break;

            case 3:
                for (int i = 0; i < 3; i++)
                {
                    melonPoints[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, pointVisibility);
                }
                break;

            case 4:
                for (int i = 0; i < 4; i++)
                {
                    melonPoints[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, pointVisibility);
                }
                break;

            case 5:
                for (int i = 0; i < 5; i++)
                {
                    melonPoints[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, pointVisibility);
                }
                break;

            default:
                break;
        }

        if (lemonScore >= winningScore)
        {
            Time.timeScale = 0;
            winScreen.SetActive(true);
            winnerText.text = "Lemon Wins !";
            melonScore = 0;
            lemonScore = 0;
        }
        if (melonScore >= winningScore)
        {
            Time.timeScale = 0;
            winScreen.SetActive(true);
            winnerText.text = "Melon Wins !";
            melonScore = 0;
            lemonScore = 0;

        }
    }

}
