using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrayTransform : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField]private GameObject OkBTN;
    private bool OKBool;
    void Start()
    {
        OkBTN = GameObject.FindGameObjectWithTag("OkBtn");
        OkBTN.GetComponent<Button>().onClick.AddListener(OK);
    }

    // Update is called once per frame
    void Update()
    {
        if (OKBool == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime * Speed);
        }
    }
    public void OK()
    {
     
        Destroy(this.GetComponent<Tray>());
        OKBool = true; 
    }
}
