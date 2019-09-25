using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTheBlackness : MonoBehaviour
{
    public GameObject TheBlackness;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            if(!TheBlackness.activeInHierarchy)
            {
                TheBlackness.SetActive(true);
            }
        }
    }
}
