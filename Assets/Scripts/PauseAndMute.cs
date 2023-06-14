using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAndMute: MonoBehaviour
{

    private bool paused;

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
        }
        else
        {
            paused = false;
            Time.timeScale = 1;
        }
    }

}
