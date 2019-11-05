using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOutTrigger : MonoBehaviour
{
    public delegate void CameraZoomOut();
    public static event CameraZoomOut EndScene;
    // Start is called before the first frame update

    private Vector3 _startPosition;
    void Start()
    {
        _startPosition = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log("Player has entered trigger");
            if (EndScene != null)
            {
                EndScene();
            }

            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<Collider2D>().enabled = false;

        }
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = _startPosition + new Vector3(0.0f, Mathf.Sin(Time.time), 0.0f);
    }
}
