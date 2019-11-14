using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowThankYou : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SmoothZoomOut.Ending += ShowIt;

        gameObject.GetComponent<Renderer>().enabled = false;
    }


    public void ShowIt()
    {
        gameObject.GetComponent<Renderer>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
