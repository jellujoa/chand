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
        rb.freezeRotation = true; // ȸ�� ����

    }

    void Update()
    {
        float X = Input.GetAxis("Horizontal"); // �¿� 
        float Y = Input.GetAxis("Vertical"); // ����

        Vector2 Move = new Vector2(X, Y).normalized;// 1�� ���� ����      
        if (Move.magnitude > 0) 
        {
            rb.velocity = Move * speed;
        }
        else
        {
            rb.velocity = Vector2.zero; // �Է� ���� �� ����
        }

    }
}
