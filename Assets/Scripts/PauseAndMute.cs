using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAndMute: MonoBehaviour
{

    public GameObject PauseMenu;

    private bool paused;
    private bool muted;

    void Start()
    {
        paused = false;
    }

    public void Pause()
    {
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
