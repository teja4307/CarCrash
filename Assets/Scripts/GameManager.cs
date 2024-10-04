using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager _inst;
    [HideInInspector]
    public  int speed = 2;
    public GameObject Menu_panel;
    public bool start;
    public GameObject GameOver_panel;
   
   // private int score;


    public void Awake()
    {
        _inst = this;
        start = false;
        Menu_panel.gameObject.SetActive(true);
        //ScoreUpdate.Instance.HighScore(ScoreUpdate.Instance.H_text);
    }

    public void StartClick()
    {
        start = true;
        Menu_panel.gameObject.SetActive(false);
        // ScoreUpdate.Instance.HighScoreUpdater(ScoreUpdate.Instance.H_text);
    }

    public void RetryClick()
    {
        ScoreUpdate.Instance.HighScoreUpdater(ScoreUpdate.Instance.H_text);

        SceneManager.LoadScene("CarGame");
    }
   


}
