using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnTrigger : MonoBehaviour
{
    //private RespawnLocator rl;
    //private Respawn PLayerRespawn;

    public delegate void PlayerDeath();
    public static event PlayerDeath Death;

    private void Start()
    {
        //rl = GameObject.FindGameObjectWithTag("RL").GetComponent<RespawnLocator>();
        //PLayerRespawn = GameObject.FindGameObjectWithTag("Player").GetComponent<Respawn>();

        RespawnTrigger.Death += ReloadLevel;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Death != null)
        {
            Death();
        }
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void ReloadLevel()
    {
        StartCoroutine(ReloadingNow());
    }

    IEnumerator ReloadingNow()
    {
        yield return new WaitForSeconds(0.25f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
