using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class GameManager : MonoBehaviour
{
    static GameManager instance;
    public static GameManager Instance { get => instance; }
    public event Action onWinGame;
    public event Action onLoseGame;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance.GetHashCode() != this.GetHashCode())
            {
                Destroy(gameObject);
                GameObject gameManager = new GameObject("GameManager");
                instance = gameManager.AddComponent<GameManager>();
            }
        }
    }
    public void WinGame()
    {
        onWinGame?.Invoke();
    }
    public void LoseGame()
    {
        onLoseGame?.Invoke();
    }
    private void OnDestroy()
    {
        instance = null;
    }
}
