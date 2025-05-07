using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{

    private Animator Characteranimator;

    protected virtual void Awake()
    {
        Characteranimator = GetComponentInChildren<Animator>();
    }
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            Characteranimator.SetBool("Up", true); 
        }
        
        else if (Input.GetKeyUp(KeyCode.W))
        {
            Characteranimator.SetBool("Up", false); 
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Characteranimator.SetBool("Down", true); 
        }
        
        else if (Input.GetKeyUp(KeyCode.S))
        {
            Characteranimator.SetBool("Down", false); 
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Characteranimator.SetBool("Right", true);
        }

        else if (Input.GetKeyUp(KeyCode.D))
        {
            Characteranimator.SetBool("Right", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Characteranimator.SetBool("Left", true);
        }

        else if (Input.GetKeyUp(KeyCode.A))
        {
            Characteranimator.SetBool("Left", false);
        }
    }
}
