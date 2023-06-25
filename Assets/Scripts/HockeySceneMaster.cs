using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HockeySceneMaster : MonoBehaviour
{

    private GameObject mouse;

    private bool reloading;

    void Start()
    {
        mouse = GameObject.Find("Mouse");

        reloading = false;
    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.R) && HockeyGameMaster.isWin)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            HockeyGameMaster.isWin = false;
        }

        if (mouse == null && !HockeyGameMaster.isWin)
        {
            if (reloading == false)
            {
                Invoke("ReloadScene", 2);
                reloading = true;
            }
        }
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
