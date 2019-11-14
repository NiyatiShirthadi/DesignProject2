using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoActivate : MonoBehaviour
{
    private Color Temp;
    // Start is called before the first frame update
    void Start()
    {
        BlacknessFadeIn.tisDark += activateDemo;

        Temp = gameObject.GetComponent<SpriteRenderer>().color;
        Temp.a = 0f;

        gameObject.GetComponent<SpriteRenderer>().color = Temp;
    }

    public void activateDemo()
    {
        StartCoroutine(Delay());
        
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1f);
        Temp.a = 1f;

        gameObject.GetComponent<SpriteRenderer>().color = Temp;
    }

    private void OnDisable()
    {
        BlacknessFadeIn.tisDark -= activateDemo;
    }
}
