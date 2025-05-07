using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
  [SerializeField] private float speed = 5f;
    

    private Rigidbody2D rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true; // 회전 방지

    }

    void Update()
    {
        float X = Input.GetAxis("Horizontal"); // 좌우 
        float Y = Input.GetAxis("Vertical"); // 상하

        Vector2 Move = new Vector2(X, Y).normalized;// 1로 고정 방향      
        if (Move.magnitude > 0) 
        {
            rb.velocity = Move * speed;
        }
        else
        {
            rb.velocity = Vector2.zero; // 입력 없을 땐 정지
        }

    }
}
