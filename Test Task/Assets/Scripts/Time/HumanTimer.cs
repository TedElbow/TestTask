using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HumanTimer : MonoBehaviour
{
    [SerializeField] private float time;
    [SerializeField] private Image timerImage;

    private bool _timerOn = false;
    private float _timeLeft = 0f;
    private void Update()
    {
        if (_timerOn)
        {
            if (_timeLeft > 0)
            {
                _timeLeft -= Time.deltaTime;
                var normalizedValue = Mathf.Clamp(_timeLeft / time, 0.0f, 1.0f);
                timerImage.fillAmount = normalizedValue;
            }
            else
            {
                MinusScore();
                this.GetComponent<HumanMover>().NeedToBack();
                _timeLeft = time;
                _timerOn = false;
            }
        }
    }

    
    public void StartTime()
    {
        time = Random.Range(5, 11);
        _timeLeft = time;
        _timerOn = true;
    }

   public void FullBar()
    {
        timerImage.fillAmount = 1;
        _timerOn = false;
    }
    private void MinusScore()
    {
        int Score = PlayerPrefs.GetInt("Score", 0);
        Score--;
        PlayerPrefs.SetInt("Score", Score);
    }
}
