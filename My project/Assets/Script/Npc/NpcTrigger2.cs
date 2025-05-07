using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NpcTrigger2 : MonoBehaviour
{
    public Canvas CanvasUI; // UI ĵ����
    private GameObject Talk; // ��ȭ UI ������Ʈ
    
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
            // SceneManager.LoadScene("NextScene"); // �� �̸��� �°� ����
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Talk.SetActive(true); // �÷��̾ �����ϸ� �˾� ǥ��
            playerInTrigger = true;
        }
       
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Talk.SetActive(false); // �÷��̾ ����� �˾� ����
            playerInTrigger = false;
        }
    }

}
