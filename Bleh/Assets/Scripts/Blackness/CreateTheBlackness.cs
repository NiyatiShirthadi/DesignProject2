using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTheBlackness : MonoBehaviour
{
    [SerializeField]
    private GameObject TheBlackness;
    private MeshRenderer Blackness;
    public GameObject BlacknessGuides;

    private Vector3 _startPosition;
    //public float UpScale;

    private void Awake()
    {
        TheBlackness = GameObject.Find("TheBlackness");
        Blackness = TheBlackness.GetComponent<MeshRenderer>();
    }
    void Start()
    {
        _startPosition = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            if (Blackness.enabled == false && !BlacknessGuides.activeInHierarchy)
            {
                Blackness.enabled = true;
                BlacknessGuides.SetActive(true);
            }
        }
    }

    void Update()
    {
        transform.position = _startPosition + new Vector3(0.0f, Mathf.Sin(Time.time), 0.0f);
    }
   
}
