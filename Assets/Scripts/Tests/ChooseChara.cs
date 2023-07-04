using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseChara : MonoBehaviour
{

    public static int charaNo;

    public void Chara1()
    {
        charaNo = 0;
        SceneManager.LoadScene("CharaPlay");
    }

    public void Chara2()
    {
        charaNo = 1;
        SceneManager.LoadScene("CharaPlay");
    }

}
