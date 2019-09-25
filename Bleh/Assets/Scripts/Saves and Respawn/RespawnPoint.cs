using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    private RespawnLocator rl;

    private void Start()
    {
        rl = GameObject.FindGameObjectWithTag("RL").GetComponent<RespawnLocator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("First Respawn Point Reached");
        if(collision.CompareTag("Player"))
        {
            rl.LastRespawnPointPos = transform.position;
            Debug.Log("New Respawn Point: " + rl.LastRespawnPointPos);
        }
    }
}
