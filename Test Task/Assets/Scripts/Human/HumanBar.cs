using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanBar : MonoBehaviour
{
    [SerializeField] private Transform _lookAt;
    [SerializeField] private Vector3 _offset;

    private Camera _cam;

    private void Start()
    {
        _cam = Camera.main;
    }

    private void FixedUpdate()
    {
        Vector3 pos = _cam.WorldToScreenPoint(_lookAt.position + _offset);

        if (transform.position != pos)
            transform.position = pos;
    }
}
