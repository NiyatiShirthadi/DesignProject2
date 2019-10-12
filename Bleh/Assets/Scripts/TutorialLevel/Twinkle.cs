using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twinkle : MonoBehaviour
{
    
    void Start()
    {
        //gameObject.transform.localScale = new Vector3 (0, 0, 0);
        //gameObject.GetComponent<SpriteRenderer>().enabled = false;
        StartTwinkle();
       // CreateTheBlackness.letThereBeDark += StartTwinkle;
    }

    public void StartTwinkle()
    {
        //gameObject.GetComponent<SpriteRenderer>().enabled = true;

        //transform.localScale = new Vector3(Mathf.PingPong(Time.time * 2, 4), Mathf.PingPong(Time.time *2, 4), transform.localScale.z);
        //StartCoroutine(Pulse());
        

    }

    /*IEnumerator Pulse()
    {
        

        yield return new WaitForSeconds(2f);
    }*/

    private void OnDisable()
    {
        CreateTheBlackness.letThereBeDark -= StartTwinkle;
    }

    
}
