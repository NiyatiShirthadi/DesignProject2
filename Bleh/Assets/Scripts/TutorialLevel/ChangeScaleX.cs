﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScaleX : MonoBehaviour
{
    public float xScale;
    public float yScale;
    private void Update()
    {
        Vector2 vec = new Vector2((Mathf.Sin(Time.time) *6) + xScale,  yScale);

        transform.localScale = vec;
    }
    
  
    
}
