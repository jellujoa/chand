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
        // 싱글톤 유지
        if (Instance == null)
        {
           Instance = this;
            DontDestroyOnLoad(gameObject); // 씬 넘어가도 파괴되지 않게
        }
        else
        {
            Destroy(gameObject); // 중복 생성을 막음
        }
    }

  
    
    public void AddDeathCount(int count)
    {
        DeathCount += count;
        Debug.Log("Death Count: " + DeathCount);      
    }
  
}
