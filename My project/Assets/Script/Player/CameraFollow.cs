using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // ���� ��� 
    public Vector3 offset; // ī�޶�� 

    void Start()
    {
        if (target == null)       
            return;

            offset = transform.position - target.position; // ī�޶�� ����� �ʱ� �Ÿ�        
    }
    private void Update()
    {
        if(target == null) // ����� ������ ����
            return;
        Vector3 pos = target.position;
        pos = target.position + offset; // ī�޶��� ��ġ�� ����� ��ġ�� �������� ���� ������ ����
        transform.position = pos; // ī�޶��� ��ġ�� ������Ʈ
    }
}
