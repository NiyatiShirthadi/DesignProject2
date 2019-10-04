using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeChildren : MonoBehaviour
{
    public GameObject MovingPlatform;
    //public GameObject HighlighterForMP;
    public GameObject Highlighters;
    public GameObject Player;
    public GameObject TheBlackness;
    public GameObject MPHighlighter;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Player has entered moving platform");
            Player.transform.parent = MovingPlatform.transform;
            //HighlighterForMP.transform.parent = MovingPlatform.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Player has left moving platform");
            Player.transform.parent = null;
            //HighlighterForMP.transform.parent = Highlighters.transform;
        }
    }

    private void Update()
    {
        if (!TheBlackness.activeInHierarchy)
        {
            MPHighlighter.GetComponent<Renderer>().enabled = false;
        }
        else if(TheBlackness.activeInHierarchy)
        {
            MPHighlighter.GetComponent<Renderer>().enabled = true;
        }
    }
}
