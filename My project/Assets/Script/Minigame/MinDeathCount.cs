using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MinDeathCount : MonoBehaviour
{
    public Text MinDeathText;
    GameManager gameManager;
    void Start()
    {
        gameManager = GameManager.Instance; // GameManager 인스턴스 가져오기
        UpdateDeathUI();

    }

    // Update is called once per frame
    public void UpdateDeathUI()
    {

        int Min = PlayerPrefs.GetInt("Min", 0);
        MinDeathText.text = $"{Min}회";
    }
}
