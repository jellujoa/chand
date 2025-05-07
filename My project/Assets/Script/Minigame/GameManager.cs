using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    static GameManager gameManager;
    public static GameManager Instance;
   


    public int DeathCount { get; private set; }

    private void Awake()
    {
        // �̱��� ����
        if (Instance == null)
        {
           Instance = this;
            DontDestroyOnLoad(gameObject); // �� �Ѿ�� �ı����� �ʰ�
        }
        else
        {
            Destroy(gameObject); // �ߺ� ������ ����
        }
    }

  
    
    public void AddDeathCount(int count)
    {
        DeathCount += count;
        Debug.Log("Death Count: " + DeathCount);      
    }
  
}
