using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NpcTrigger3 : MonoBehaviour
{
    
    public Canvas CanvasUI; // UI ĵ����
    private GameObject Talk; // ��ȭ UI ������Ʈ
    public Player player; // �÷��̾� ������Ʈ
    public GameManager gameManager; // ���� �Ŵ���
    private bool playerInTrigger = false;
    void Start()
    {
       
        Talk = CanvasUI.transform.Find("Talk").gameObject; // "Talk"�̶�� �̸��� ������Ʈ�� ã��
        Talk.SetActive(false); // ������ �� �˾� ����
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInTrigger && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("�� ��ȯ");
            SceneManager.LoadScene("MainScene"); // �� �̸��� �°� ����f
            
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            player = other.GetComponent<Player>(); // Player ������Ʈ ��������
            Talk.SetActive(true); // �÷��̾ �����ϸ� �˾� ǥ��
            playerInTrigger = true;
            player.GodMode = true; // �÷��̾��� �� ��� Ȱ��ȭ
          
        }
       
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player = other.GetComponent<Player>();
            Talk.SetActive(false); // �÷��̾ ����� �˾� ����
           
            playerInTrigger = false;
            player.GodMode = false; // �÷��̾��� �� ��� ��Ȱ��ȭ
        }
    }

}
