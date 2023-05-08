using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMaster : MonoBehaviour
{

    private GameObject mouse;

    public GameObject theRock;

    private bool reloading;

    void Start()
    {
        theRock.SetActive(false);
        mouse = GameObject.Find("Mouse");

        reloading = false;
    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.R) && GameMaster.isWin)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            GameMaster.isWin = false;
        }

        if (mouse == null)
        {
            if (reloading == false)
            {
                theRock.SetActive(true);
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
