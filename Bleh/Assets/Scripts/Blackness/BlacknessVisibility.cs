using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlacknessVisibility : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;

        CreateTheBlackness.letThereBeDark += RevealBlackness;
    }
    // Start is called before the first frame update
    private void Awake()
    {
        
    }
    
    public void RevealBlackness()
    {
        //Debug.Log("Blackness is HERE!");
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }

    private void OnDisable()
    {
        CreateTheBlackness.letThereBeDark -= RevealBlackness;
    }

}
