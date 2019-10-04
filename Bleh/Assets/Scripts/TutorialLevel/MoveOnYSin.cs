using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnYSin : MonoBehaviour
{
    private Vector3 _startPosition;
    //public float UpScale;

    void Start()
    {
        _startPosition = transform.position;
    }

  /*  private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.collider.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.collider.transform.SetParent(transform);
        }
    }*/

    void Update()
    {
        transform.position = _startPosition + new Vector3(0.0f, Mathf.Sin(Time.time) * 5, 0.0f);
    }
}
