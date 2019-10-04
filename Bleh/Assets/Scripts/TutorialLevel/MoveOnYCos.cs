using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnYCos : MonoBehaviour
{
    private Vector3 _startPosition;
    //public float UpScale;

    void Start()
    {
        _startPosition = transform.position;
    }

    void Update()
    {
        transform.position = _startPosition + new Vector3(0.0f, Mathf.Cos(Time.time) * 5, 0.0f);
    }
}
