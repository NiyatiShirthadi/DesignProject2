using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeVisibility : MonoBehaviour
{
    void Start()
    {
        CreateTheBlackness.letThereBeDark += HideSpike;

        gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }

    public void HideSpike()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    private void OnDisable()
    {
        CreateTheBlackness.letThereBeDark -= HideSpike;
    }
}
