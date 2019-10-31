using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBW2PtsOpp : MonoBehaviour
{
    public Transform LeftPos;
    public Transform RightPos;

    private Vector3 Pos1;
    private Vector3 Pos2;
    public float speed;
    void Start()
    {
        Pos1 = LeftPos.transform.position;
        Pos2 = RightPos.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        {
            transform.position = Vector3.Lerp(Pos2, Pos1, (Mathf.Cos(speed * Time.time) + 1.0f) / 2.0f);
        }
    }
}
