using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowyActivate : MonoBehaviour
{
    private Color Temp;
    // Start is called before the first frame update
    void Start()
    {
        BlacknessFadeIn.tisDark += activateGlow;

        Temp = gameObject.GetComponent<SpriteRenderer>().color;
        Temp.a = 0f;

        gameObject.GetComponent<SpriteRenderer>().color = Temp;
    }

    public void activateGlow()
    {
        Temp.a = 1f;

        gameObject.GetComponent<SpriteRenderer>().color = Temp;
    }


    private void OnDisable()
    {
        BlacknessFadeIn.tisDark -= activateGlow;
    }
}
