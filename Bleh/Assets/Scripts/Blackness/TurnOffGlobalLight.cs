using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class TurnOffGlobalLight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreateTheBlackness.letThereBeDark += GLOff;
    }

    public void GLOff()
    {
        gameObject.GetComponent<Light2D>().intensity = 0;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
