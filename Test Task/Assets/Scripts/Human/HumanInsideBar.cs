using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanInsideBar : MonoBehaviour
{
    public int _figureCount;
    [SerializeField] private GameObject[] _figureImages;
    [SerializeField] private Sprite[] _figurePrefabes;
    public string[] Figures;
    public int RandomImage;



    void Start()
    {
        FigureCount();
       
    }        

    // Update is called once per frame
    void Update()
    {
        


    }

    public void FigureCount()
    {
        _figureCount = Random.Range(1, 4);
        InstantiateFigureImage();
    }

    void InstantiateFigureImage()
    {
        if (_figureCount == 1)
        {
            _figureImages[2].SetActive(false);
            _figureImages[1].SetActive(false);
            _figureImages[0].SetActive(true);
                RandomImage = Random.Range(0, 3);
                _figureImages[0].GetComponent<Image>().sprite = _figurePrefabes[RandomImage];
                if (RandomImage == 2)
                {
                Figures[0] = "LongCube";
                _figureImages[0].transform.localScale = new Vector3(1f, 1.5f, 1f);
                  
                }
                else
                {
                    _figureImages[0].transform.localScale = new Vector3(1f, 1f, 1f);
                }
                if (RandomImage == 0)
                {
                    Figures[0] = "Sphere";
                }
                if (RandomImage == 1)
                {
                    Figures[0] = "Cube";
                }
            
        }
        if (_figureCount == 2)
        {
            for (int i = 0; i <=1; i++)
            {
                _figureImages[i].SetActive(true);
                RandomImage = Random.Range(0, 3);
                _figureImages[i].GetComponent<Image>().sprite = _figurePrefabes[RandomImage];
                if(RandomImage == 2)
                {
                    Figures[i] = "LongCube";
                    _figureImages[i].transform.localScale = new Vector3(1f, 1.5f, 1f);
                    
                }
                else
                {
                    _figureImages[i].transform.localScale = new Vector3(1f, 1f, 1f);
                }
                if (RandomImage == 0)
                {
                    Figures[i] = "Sphere";
                }
                if (RandomImage == 1)
                {
                    Figures[i] = "Cube";
                }
            }
        }
        if (_figureCount == 3)
        {
            for (int i = 0; i <= 2; i++)
            {
                _figureImages[i].SetActive(true);
                RandomImage = Random.Range(0, 3);
                _figureImages[i].GetComponent<Image>().sprite = _figurePrefabes[RandomImage];
                if (RandomImage == 2)
                {
                    Figures[i] = "LongCube";
                    _figureImages[i].transform.localScale = new Vector3(1f, 1.5f, 1f);
                    
                }
                else
                {
                    _figureImages[i].transform.localScale = new Vector3(1f, 1f, 1f);
                }
                if (RandomImage == 0)
                {
                    Figures[i] = "Sphere";
                }
                if (RandomImage == 1)
                {
                    Figures[i] = "Cube";
                }
            }
        }
    }

  
}
