using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    public static ScoreUpdate Instance;

    public int score;
    public int highScore;
    public Text scoreText;
    public Text H_text;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        //PlayerPrefs.DeleteAll();
        UpdateScore(0,scoreText);
        HighScoreUpdater(H_text);

    }

    public void UpdateScore(int score,Text _text)
    {
        //score++;
        _text.text = "Score: " + score;

    }
    public void HighScoreUpdater(Text _text)
    {
        highScore = PlayerPrefs.GetInt("HighScore");
        _text.text = "HighScore: " + highScore;
     
    }
    public void GameOver(int score)
    {
        //GameOver_panel.SetActive(true);
        GameManager._inst.GameOver_panel.SetActive(true);

        if (score >highScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
        //ScoreUpdate.Instance.HighScore(ScoreUpdate.Instance.H_text);
    }

}
