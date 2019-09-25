using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnTrigger : MonoBehaviour
{
    private RespawnLocator rl;
    private Respawn PLayerRespawn;

    private void Start()
    {
        rl = GameObject.FindGameObjectWithTag("RL").GetComponent<RespawnLocator>();
        PLayerRespawn = GameObject.FindGameObjectWithTag("Player").GetComponent<Respawn>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      
    }
}
