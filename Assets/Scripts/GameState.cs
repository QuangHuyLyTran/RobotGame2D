using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    [SerializeField] GameObject gameOverUI;
    [SerializeField] GameObject gameWinUI;
    private void Awake()
    {
        GameManager.Instance.onWinGame += OnWinGame;
        GameManager.Instance.onLoseGame += OnLoseGame;
    }
    void OnWinGame()
    {
        gameWinUI.SetActive(true);
    }
    void OnLoseGame()
    {
        gameOverUI.SetActive(true);
    }
}
