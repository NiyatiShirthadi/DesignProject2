using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingPlatform : MonoBehaviour
{
    private Renderer Rend;
    private Collider2D Col;

    public float VisibleWait = 2f;
    public float InvisibleWait = 4f;




    void Start()
    {
        Rend = gameObject.GetComponent<Renderer>();
        Col = gameObject.GetComponent<Collider2D>();
    }

    IEnumerator Visibile()
    {
        yield return new WaitForSeconds(VisibleWait);
        Rend.enabled = false;
        Col.enabled = false;
    }

    IEnumerator Invisible()
    {
        yield return new WaitForSeconds(InvisibleWait);
        Rend.enabled = true;
        Col.enabled = true;
    }

    private void Update()
    {
        StartCoroutine(Visibile());
        StartCoroutine(Invisible());
    }

}
