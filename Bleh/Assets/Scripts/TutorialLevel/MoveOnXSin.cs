using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnXSin : MonoBehaviour
{
    private Vector3 _startPosition;
    //public float UpScale;
    public GameObject Player;
   

    void Start()
    {
        _startPosition = transform.position;
    }
 
    // Start is called before the first frame update
   

    void Update()
    {
        transform.position = _startPosition + new Vector3(Mathf.Sin(Time.time) * 5, 0.0f, 0.0f);
    }
}
