using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharaPlay : MonoBehaviour
{
    private string catName;
    public GameObject cat;
    public Sprite cat0Image;
    public Sprite cat1Image;

    public TMP_Text gameText;

    void Start()
    {
        switch (ChooseChara.charaNo)
        {
            case 0:
                cat.GetComponent<SpriteRenderer>().sprite = cat0Image;
                break;

            case 1:
                cat.GetComponent<SpriteRenderer>().sprite = cat1Image;
                break;

            default:
                break;
        }
    }   

    // Update is called once per frame
    void Update()
    {
        gameText.text = "You are " + catName;
    }
}
