using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCollider : MonoBehaviour
{
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
           // Debug.Log("Collider");
            ScoreUpdate.Instance.score++;

            ScoreUpdate.Instance.UpdateScore(ScoreUpdate.Instance.score,ScoreUpdate.Instance.scoreText);
            //ScoreUpdate.Instance.HighScore(ScoreUpdate.Instance.H_text);
        }
    }
}
