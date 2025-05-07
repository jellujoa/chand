using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    FlyCamera flyCamera; // FlyCamera 인스턴스
    Animator animator;
    Rigidbody2D rb;
    bool isDead = false; // 죽었는지 여부
    bool isJumping = false; // 점프 중인지 여부
    float deathCooldown = 0f; // 죽은 후 재시작 대기 시간
    public bool GodMode = false; // 신 모드 여부
    public float moveSpeed = 3f; // 정면으로 가는 속도
    GameManager gameManager;
    // 죽었는지 여부
   
        // Start is called before the first frame update
        void Start()
    {
        gameManager = GameManager.Instance; // GameManager 인스턴스 가져오기
        flyCamera = FindObjectOfType<FlyCamera>();  // FlyCamera 인스턴스 가져오기
        animator = GetComponentInChildren<Animator>();
       rb = GetComponent<Rigidbody2D>();
       rb.freezeRotation = true; // 물리 엔진에서 회전하지 않도록 설정

       
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
                deathCooldown -= Time.deltaTime; // 대기 시간 감소
            }
        }
        else
        {
           if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                isJumping = true; // 점프 시작
            }
            // 스페이스바 또는 마우스 클릭


        }
    }

    private void FixedUpdate()
    {
        if (isDead) return;
        Vector2 velocity = rb.velocity;
        velocity.x = moveSpeed; // 정면으로 가는 속도
        if (isJumping)
        {
            velocity.y += moveSpeed; // 점프 속도
            isJumping = false; // 점프 완료
        }
        rb.velocity = velocity; // 물리 엔진에 속도 적용
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(GodMode)
            return;        
        if(isDead) 
            return;
      
            isDead = true; // 죽음 처리
            deathCooldown = 1f; // 재시작 대기 시간 설정

            animator.speed = 0f; // 죽는 애니메이션 재생

        gameManager.AddDeathCount(+1);
        
        flyCamera.ShowCanvas();
    }
   
}
