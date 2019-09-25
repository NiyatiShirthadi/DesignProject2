using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnLocator : MonoBehaviour
{
    private static RespawnLocator instance;
    public Vector3 LastRespawnPointPos;

    private void Start()
    {
        
    }
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
