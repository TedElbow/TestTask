using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartPanel : MonoBehaviour
{
    public List<GameObject> AllObjects;

    private void Start()
    {
        for (int i = 0; i < AllObjects.Count; i++)
        {
            AllObjects[i].SetActive(false);
        }
        Time.timeScale = 0.0001f;

    }
   
    public void RestartBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
