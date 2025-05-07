using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NpcTrigger2 : MonoBehaviour
{
    public Canvas CanvasUI; // UI 캔버스
    private GameObject Talk; // 대화 UI 오브젝트
    
    private bool playerInTrigger = false;
    void Start()
    {
       
        Talk = CanvasUI.transform.Find("Talk").gameObject; // "Talk"이라는 이름의 오브젝트를 찾음
        Talk.SetActive(false); // 시작할 때 팝업 숨김
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInTrigger && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("씬 전환");
            // SceneManager.LoadScene("NextScene"); // 씬 이름에 맞게 수정
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Talk.SetActive(true); // 플레이어가 접근하면 팝업 표시
            playerInTrigger = true;
        }
       
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Talk.SetActive(false); // 플레이어가 벗어나면 팝업 숨김
            playerInTrigger = false;
        }
    }

}
