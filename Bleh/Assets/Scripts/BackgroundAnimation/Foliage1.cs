using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foliage1 : MonoBehaviour
{
    private Animator Anim;

    private void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Anim.SetBool("Ruffle", true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Anim.SetBool("Ruffle", false);
        }
    }



}
