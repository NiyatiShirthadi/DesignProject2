using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlayerChild : MonoBehaviour
{
    public GameObject Player;
    public GameObject MovingPlatform;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Player has entered moving platform");
            Player.transform.parent = MovingPlatform.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Player has left moving platform");
           Player.transform.parent = null;
        }
    }
}
