using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class PlayerPointLt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreateTheBlackness.letThereBeDark += PlayerLightOn;

        gameObject.GetComponent<Light2D>().intensity = 0;
    }

    public void PlayerLightOn()
    {
        gameObject.GetComponent<Light2D>().intensity = 1;
    }

    private void OnDisable()
    {
        CreateTheBlackness.letThereBeDark -= PlayerLightOn;
    }
}
