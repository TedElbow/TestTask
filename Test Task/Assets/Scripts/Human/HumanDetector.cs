using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanDetector : MonoBehaviour
{
    public int Test;
    public HumanInsideBar _humanInside;
    public string[] FigureTest;
    public List<string> inTrigger;
    public bool _destroy;


    private void Start()
    {
        inTrigger = new List<string>();
       
    }
    private void Update()
    {
        Test = _humanInside._figureCount;
    }
    private void Check0()
    {
        if (inTrigger.Count == 3)
        {
           
                
              
                for (int a = 0; a < inTrigger.Count; a++)
                  {
                    if (inTrigger[a] == _humanInside.Figures[0])
                    {
                       inTrigger.Remove(inTrigger[a]);
                        this.GetComponent<HumanMover>().NeedToBack();
                        _destroy = true;
                         PlusScore();
                          this.GetComponent<HumanTimer>().FullBar();
                    }
                }
                   

            
        }
    }
    private void Check1()
    {
       
        if (inTrigger.Count == 4)
        {
            
                for (int i = 0; i < inTrigger.Count; i++)
                {
                    if (inTrigger[i] == _humanInside.Figures[0])
                    {
                        inTrigger.Remove(inTrigger[i]);
                        for (int a = 0; a < inTrigger.Count; a++)
                        {
                            if (inTrigger[a] == _humanInside.Figures[1])
                            {
                                this.GetComponent<HumanMover>().NeedToBack();
                                _destroy = true;
                                PlusScore();
                            this.GetComponent<HumanTimer>().FullBar();
                            }
                        }
                    }

                }

            
        }
    }
    private void Check2()
    {
        if (inTrigger.Count == 5)
        {
                for (int i = 0; i < inTrigger.Count; i++)
                {
                    if (inTrigger[i] == _humanInside.Figures[0])
                    {
                        inTrigger.Remove(inTrigger[i]);
                        for (int a = 0; a < inTrigger.Count; a++)
                        {
                            if (inTrigger[a] == _humanInside.Figures[1])
                            {
                                inTrigger.Remove(inTrigger[a]);
                                for (int b = 0; b < inTrigger.Count; b++)
                                {
                                    if (inTrigger[b] == _humanInside.Figures[2])
                                    {
                                        this.GetComponent<HumanMover>().NeedToBack();
                                        _destroy = true;
                                        PlusScore();
                                    this.GetComponent<HumanTimer>().FullBar();
                                
                                    }
                                }
                            }

                        }
                    }


                }

            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        inTrigger.Add(other.tag);
        StartCoroutine(Wait());
        if (Test == 3)
        {
            Check2();
        }


    }

    private void OnTriggerStay(Collider other)
    {
        if(_destroy == true)
        {
            Destroy(other.gameObject,0.81f);
            StartCoroutine(WaitDestroy());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        inTrigger.Clear();
        
    }
    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.8f);
        if (Test ==1)
        {
            Check0();
        }
        if (Test == 2)
        {
            Check1();
        }
       
    }
    private IEnumerator WaitDestroy()
    {
        yield return new WaitForSeconds(0.82f);
        _destroy = false;
    }
    private void PlusScore()
    {
        int Score = PlayerPrefs.GetInt("Score", 0);
        Score++;
        PlayerPrefs.SetInt("Score", Score);
    }
}
