using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tray : MonoBehaviour
{
    [SerializeField] private int num = 0;
    [SerializeField] private Transform[] _position;
    [SerializeField] private GameObject _sphere;
    [SerializeField] private GameObject _cube;
    [SerializeField] private GameObject _longCube;
    private GameObject SphereBTN;
    private GameObject CubeBTN;
    private GameObject LongCubeBTN;
    

    private void Start()
    {
        SphereBTN = GameObject.FindGameObjectWithTag("SphereBtn");
        SphereBTN.GetComponent<Button>().onClick.AddListener(Sphere);
        CubeBTN = GameObject.FindGameObjectWithTag("CubeBtn");
        CubeBTN.GetComponent<Button>().onClick.AddListener(Cube);
        LongCubeBTN = GameObject.FindGameObjectWithTag("LongCubeBtn");
        LongCubeBTN.GetComponent<Button>().onClick.AddListener(LongCube);
    }

    private void FixedUpdate()
    {
       
    }
    public void Sphere()
    {
        if (num < 3)
        {
            Instantiate(_sphere, _position[num].position, Quaternion.identity, _position[num]);
            num++;
        }
    }
    public void Cube()
    {
        if (num < 3)
        {
            Instantiate(_cube, _position[num].position, Quaternion.identity, _position[num]);
            num++;
        }
    }
    public void LongCube()
    {
        if (num < 3)
        {
            Instantiate(_longCube, _position[num].position, Quaternion.identity, _position[num]);
            num++;
        }
    }

    public void OK()
    {

    }
}
