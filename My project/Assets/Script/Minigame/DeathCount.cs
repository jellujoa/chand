using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class DeathCount : MonoBehaviour
{
    public Text deathCountTextUI; // UI �ؽ�Ʈ ���� (�ν����Ϳ��� ����)
   

    void Start()
    {
        // GameManager���� DeathCount�� �����ͼ� UI�� ǥ��
        int deathCount = GameManager.Instance.DeathCount;

        // �ؽ�Ʈ�� ��ȯ�Ͽ� UI�� ǥ��
        deathCountTextUI.text = $"{deathCount}ȸ";
    }








}
