using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnXSin : MonoBehaviour
{
    private Vector3 _startPosition;
    //public float UpScale;
    public GameObject Player;
    public float Speed;

    void Start()
    {
        Player = GameObject.Find("Player");
        _startPosition = transform.position;
    }
 
    // Start is called before the first frame update
   

    void Update()
    {
        transform.position = _startPosition + new Vector3(Mathf.Sin(Time.time) * Speed, 0.0f, 0.0f);
    }
}
