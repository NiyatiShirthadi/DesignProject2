using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToExitPortal : MonoBehaviour
{
    private Respawn Respawn;
    public GameObject TheBlackness;

    private void Awake()
    {
        Respawn = GameObject.FindGameObjectWithTag("Player").GetComponent<Respawn>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Go To Exit Now");
        if(collision.CompareTag("Player"))
        {
            Respawn.ExitLevel();
            TheBlackness.SetActive(false);
        }
    }
}
