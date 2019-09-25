using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private RespawnLocator rl;

    private void Awake()
    {
        rl = GameObject.FindGameObjectWithTag("RL").GetComponent<RespawnLocator>();
        transform.position = rl.transform.position;
    }
    private void Start()
    {
      
       transform.position = rl.LastRespawnPointPos;
        Debug.Log("Respawning at: " + transform.position);
    }

}
