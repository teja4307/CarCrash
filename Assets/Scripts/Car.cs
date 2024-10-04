using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            //Debug.Log("Collider");
            ScoreUpdate.Instance.GameOver(ScoreUpdate.Instance.score);
            GameManager._inst.speed = 0;
            GameManager._inst.GameOver_panel.SetActive(true);
            ScoreUpdate.Instance.HighScoreUpdater(ScoreUpdate.Instance.H_text);
        }
    }
   
   
}
