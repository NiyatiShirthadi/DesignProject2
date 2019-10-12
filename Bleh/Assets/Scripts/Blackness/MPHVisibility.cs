using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPHVisibility : MonoBehaviour
{
    //private MeshRenderer TheBlackness;
    void Start()
    {
        CreateTheBlackness.letThereBeDark += ShowMP;

        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    public void ShowMP()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }

    private void OnDisable()
    {
        CreateTheBlackness.letThereBeDark -= ShowMP;
    }


}
