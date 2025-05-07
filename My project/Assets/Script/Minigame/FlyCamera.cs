using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyCamera : MonoBehaviour
{
    public GameObject UIState;
    public Transform target;
    float offsetX;

    void Start()
    {
        
        if (target == null)
            return;

        offsetX = transform.position.x - target.position.x;
    }

    void Update()
    {
        if (target == null)
            return;

        Vector3 pos = transform.position;
        pos.x = target.position.x + offsetX;
        transform.position = pos;
    }
    public void ShowCanvas()
    {
        UIState.SetActive(true); // UI Ȱ��ȭ
    }
    public void HideCanvas()
    {
        UIState.SetActive(false); // UI ��Ȱ��ȭ
    }
}
