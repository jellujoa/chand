using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // 따라갈 대상 
    public Vector3 offset; // 카메라와 

    void Start()
    {
        if (target == null)       
            return;

            offset = transform.position - target.position; // 카메라와 대상의 초기 거리        
    }
    private void Update()
    {
        if(target == null) // 대상이 없으면 종료
            return;
        Vector3 pos = target.position;
        pos = target.position + offset; // 카메라의 위치를 대상의 위치에 오프셋을 더한 값으로 설정
        transform.position = pos; // 카메라의 위치를 업데이트
    }
}
