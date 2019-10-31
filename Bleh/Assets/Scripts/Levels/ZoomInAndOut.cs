using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomInAndOut : MonoBehaviour
{

    public Camera MainCamera;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Debug.Log("Player has entered trigger");
            MainCamera.orthographicSize = 15f;
            //MainCamera.orthographicSize = Mathf.Lerp (MainCamera.orthographicSize, 15f, Time.deltaTime);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player has left trigger");
            MainCamera.orthographicSize = 7.5f;
            //MainCamera.orthographicSize = Mathf.Lerp(MainCamera.orthographicSize, 7.5f, Time.deltaTime);
        }
    }
}
