using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTheBlackness : MonoBehaviour
{
    public GameObject TheBlackness;
    public GameObject BlacknessGuides;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            if(!TheBlackness.activeInHierarchy && !BlacknessGuides.activeInHierarchy)
            {
                TheBlackness.SetActive(true);
                BlacknessGuides.SetActive(true);
            }
        }
    }
}
