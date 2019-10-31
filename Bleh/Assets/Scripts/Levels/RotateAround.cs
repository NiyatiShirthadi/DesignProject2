using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.RotateAround(transform.position, transform.up, Time.deltaTime * 90f);
    }

    void Update()
    {
        
    }
}
