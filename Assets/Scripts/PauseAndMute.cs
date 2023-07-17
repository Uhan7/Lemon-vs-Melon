using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAndMute: MonoBehaviour
{

    public GameObject PauseMenu;

    public GameObject[] Buttons;
    private int buttonNum;

    private bool paused;
    private bool muted;

    void Start()
    {
        paused = false;
        buttonNum = 0;
    }

    public void Pause()
    {

        if (Buttons[buttonNum].activeInHierarchy)
        {
            Buttons[buttonNum].SetActive(false);
            buttonNum = (buttonNum + 1) % 8;
            Buttons[buttonNum].SetActive(true);
        }

        if (!paused)
        {
            paused = true;
            Time.timeScale = 0;
            PauseMenu.SetActive(true);
            AudioListener.volume = 0.4f;
        }
        else
        {
            paused = false;
            Time.timeScale = 1;
            PauseMenu.SetActive(false);
            AudioListener.volume = 1;
        }
    }

    public void Mute()
    {
        if (!muted)
        {
            muted = true;
            AudioListener.volume = 0;
        }
        else
        {
            muted = false;
            AudioListener.volume = 1;
        }
    }

}
