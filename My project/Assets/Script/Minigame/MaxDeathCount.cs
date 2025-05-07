using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MaxDeathCount : MonoBehaviour
{
    public Text MaxDeathText;
    void Start()
    {
        int Max = PlayerPrefs.GetInt("Max", 0);
        MaxDeathText.text = $"{Max}회";
    }

    // Update is called once per frame
    
}
