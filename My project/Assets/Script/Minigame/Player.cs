using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    FlyCamera flyCamera; // FlyCamera �ν��Ͻ�
    Animator animator;
    Rigidbody2D rb;
    bool isDead = false; // �׾����� ����
    bool isJumping = false; // ���� ������ ����
    float deathCooldown = 0f; // ���� �� ����� ��� �ð�
    public bool GodMode = false; // �� ��� ����
    public float moveSpeed = 3f; // �������� ���� �ӵ�
    GameManager gameManager;
    // �׾����� ����
   
        // Start is called before the first frame update
        void Start()
    {
        gameManager = GameManager.Instance; // GameManager �ν��Ͻ� ��������
        flyCamera = FindObjectOfType<FlyCamera>();  // FlyCamera �ν��Ͻ� ��������
        animator = GetComponentInChildren<Animator>();
       rb = GetComponent<Rigidbody2D>();
       rb.freezeRotation = true; // ���� �������� ȸ������ �ʵ��� ����

       
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            if (deathCooldown <= 0f)
            {
                       
            }
            else
            {
                deathCooldown -= Time.deltaTime; // ��� �ð� ����
            }
        }
        else
        {
           if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                isJumping = true; // ���� ����
            }
            // �����̽��� �Ǵ� ���콺 Ŭ��


        }
    }

    private void FixedUpdate()
    {
        if (isDead) return;
        Vector2 velocity = rb.velocity;
        velocity.x = moveSpeed; // �������� ���� �ӵ�
        if (isJumping)
        {
            velocity.y += moveSpeed; // ���� �ӵ�
            isJumping = false; // ���� �Ϸ�
        }
        rb.velocity = velocity; // ���� ������ �ӵ� ����
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(GodMode)
            return;        
        if(isDead) 
            return;
      
            isDead = true; // ���� ó��
            deathCooldown = 1f; // ����� ��� �ð� ����

            animator.speed = 0f; // �״� �ִϸ��̼� ���

        gameManager.AddDeathCount(+1);
        
        flyCamera.ShowCanvas();
    }
   
}
