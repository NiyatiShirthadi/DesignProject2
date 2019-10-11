using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CC2D;

[System.Serializable]
public class CheckSteps : MonoBehaviour
{
    public GameObject Step;
    private Meepy_CharacterController _controller;
    //private bool SteppedOn = false;
    public Vector3 LowerIt;
    private GameObject TheBlackness;
    private MeshRenderer Blackness;

    public bool Aboolyy;

    
    private void Awake()
    {
        TheBlackness = GameObject.Find("TheBlackness");
        Blackness = TheBlackness.GetComponent<MeshRenderer>();
        Blackness.enabled = false;
        _controller = GetComponent<Meepy_CharacterController>();
    }
    private void Update()
    {
        if(Blackness.enabled == true)
        { 
        if(Aboolyy == true && _controller.isGrounded)
        {
            Instantiate(Step, transform.position - LowerIt, Quaternion.identity);
                Debug.Log("Glowy is on");
           
            Aboolyy = false;
        }
        }
    }
}
