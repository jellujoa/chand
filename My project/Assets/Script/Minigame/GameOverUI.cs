using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    Button ExitButton;
    Button RestartButton;
    void Start()
    {
        ExitButton = GameObject.Find("Exit").GetComponent<Button>();
        RestartButton = GameObject.Find("Restart").GetComponent<Button>();

        ExitButton.onClick.AddListener(ExitGame);
        RestartButton.onClick.AddListener(LoadTargetScene);
    }
    public void LoadTargetScene()
    {
        SceneManager.LoadScene("FlyScene"); // �ε��� �� �̸�
    }
    public void ExitGame()
    {
        SceneManager.LoadScene("MainScene"); // �ε��� �� �̸�
    }
}
