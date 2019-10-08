using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private RespawnLocator rl;
//public GameObject ExitToLocation;

    private void Awake()
    {
        rl = GameObject.FindGameObjectWithTag("RL").GetComponent<RespawnLocator>();
    }
    private void Start()
    {
      
       transform.position = rl.LastRespawnPointPos;
        //Debug.Log("Respawning at: " + transform.position);
    }

  /*  public void ExitLevel()
    {
        transform.position = ExitToLocation.transform.position;
    }*/


}
