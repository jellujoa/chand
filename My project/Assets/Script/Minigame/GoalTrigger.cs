using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NpcTrigger3 : MonoBehaviour
{
    
    public Canvas CanvasUI; // UI 캔버스
    private GameObject Talk; // 대화 UI 오브젝트
    public Player player; // 플레이어 오브젝트
    public GameManager gameManager; // 게임 매니저
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
            SceneManager.LoadScene("MainScene"); // 씬 이름에 맞게 수정f
            
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            player = other.GetComponent<Player>(); // Player 컴포넌트 가져오기
            Talk.SetActive(true); // 플레이어가 접근하면 팝업 표시
            playerInTrigger = true;
            player.GodMode = true; // 플레이어의 신 모드 활성화
          
        }
       
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player = other.GetComponent<Player>();
            Talk.SetActive(false); // 플레이어가 벗어나면 팝업 숨김
           
            playerInTrigger = false;
            player.GodMode = false; // 플레이어의 신 모드 비활성화
        }
    }

}
