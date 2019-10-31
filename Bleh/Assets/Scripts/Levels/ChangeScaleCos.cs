using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScaleCos : MonoBehaviour
{
    public float xScale;
    public float yScale;
    private void Update()
    {
        Vector2 vec = new Vector2((Mathf.Cos(Time.time) * 4) + xScale, yScale);

        transform.localScale = vec;
    }
}
