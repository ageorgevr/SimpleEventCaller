using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreSystem : MonoBehaviour
{

    int highscore = 0;

    Text text;
    [SerializeField] ScoreSystem scoreSystem;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        GameManager.instance.gameLost += CheckForHighScore;
    }

    void CheckForHighScore()
    {
        if( scoreSystem.score > highscore)
        {
            highscore = scoreSystem.score;
            text.text = "High Score: " + highscore.ToString();
        }
    }
}
