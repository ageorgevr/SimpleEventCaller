using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //IMPORTANT

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public event Action gameStarted, gameLost, scoreIncremented;
    bool isPlaying = false;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (isPlaying == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isPlaying = true;
                StartGame();
            }
        }
    }

    public void StartGame()
    {
        gameStarted?.Invoke();
    }

    public void LoseGame()
    {
        isPlaying = false;
        gameLost?.Invoke();
    }

    public void IncrementScore()
    {
        scoreIncremented?.Invoke();
    }
}
