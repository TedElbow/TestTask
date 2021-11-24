using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tray"))
        {
            Destroy(other.gameObject,1);
            MinusScore();
        }
    }
    private void MinusScore()
    {
        int Score = PlayerPrefs.GetInt("Score", 0);
        Score--;
        PlayerPrefs.SetInt("Score", Score);
    }
}
