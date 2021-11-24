using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanMover : MonoBehaviour
{
    [SerializeField]private bool _needToMove;
    [SerializeField] private bool _needToBack;
    public float Speed;
    [SerializeField] float TimeStart;
    public HumanInsideBar _HumanInsideBar;


    private void Start()
    {
        _needToMove = false;
        StartCoroutine(WaitBeforeMove());
    }

    private void Update()
    {
        
        if (_needToMove == true)
        {
            if (this.transform.position.z > 0)
            {
                transform.Translate(Vector3.back * Time.deltaTime * Speed);
            }
            else
            {
                this.GetComponent<HumanTimer>().StartTime();
                _needToMove = false;
                
            }
        }
        if (_needToBack == true)
        {
            if (this.transform.position.z < 3.5f)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * Speed);
            }
            else
            {
                _needToBack = false;
                StartCoroutine(WaitAfterBack());
                _HumanInsideBar.FigureCount();
                this.GetComponent<HumanTimer>().FullBar();
            }
        }
        
        
        

    }

    private IEnumerator WaitBeforeMove()
    {
        yield return new WaitForSeconds(TimeStart);
        _needToMove = true;
    }
    private IEnumerator WaitAfterBack()
    {
        yield return new WaitForSeconds(5);
        _needToMove = true;
    }

    public void NeedToBack()
    {
        _needToBack = true;
    }
}
