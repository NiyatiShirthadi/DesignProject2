using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealHighlights : MonoBehaviour
{
    private void Start()
    {
        for (int a = 0; a < transform.childCount; a++)
        {
            transform.GetChild(a).gameObject.SetActive(false);
        }

        CreateTheBlackness.letThereBeDark += RevealThePath;
    }
    private void Awake()
    {
        
    }

    public void RevealThePath()
    {
        //Debug.Log("Enabling highlights NOW");
        for (int a = 0; a < transform.childCount; a++)
        {
            transform.GetChild(a).gameObject.SetActive(true);
        }
    }

    private void OnDisable()
    {
        CreateTheBlackness.letThereBeDark -= RevealThePath;
    }
}
