using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public int score { get; private set;} = 0;
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        GameManager.instance.scoreIncremented += incrementScore;
        GameManager.instance.gameStarted += ResetScore;
    }

    void ResetScore()
    {
        score = 0;
        DisplayScore();
    }

    void incrementScore()
    {
        score++;
        DisplayScore();
    }

    private void DisplayScore()
    {
        text.text = score.ToString();
    }
}
