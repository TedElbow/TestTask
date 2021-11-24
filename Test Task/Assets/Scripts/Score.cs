using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int ScoreCount;
    [SerializeField] Text ScoreInGame;
    [SerializeField] Text ScoreInEndGame;

    private void Start()
    {
       PlayerPrefs.SetInt("Score", 0);
        Time.timeScale = 1f;
    }

    private void Update()
    {
        ScoreCount = PlayerPrefs.GetInt("Score", 0);
        ScoreInGame.text = ScoreCount.ToString();
        ScoreInEndGame.text = ScoreCount.ToString();
    }
}
