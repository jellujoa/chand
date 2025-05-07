using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class DeathCount : MonoBehaviour
{
    public Text deathCountTextUI; // UI 텍스트 연결 (인스펙터에서 연결)
   

    void Start()
    {
        // GameManager에서 DeathCount를 가져와서 UI에 표시
        int deathCount = GameManager.Instance.DeathCount;

        // 텍스트로 변환하여 UI에 표시
        deathCountTextUI.text = $"{deathCount}회";
    }








}
