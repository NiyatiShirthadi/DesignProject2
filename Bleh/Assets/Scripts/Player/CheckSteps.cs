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
    //private GameObject TheBlackness;
    //private MeshRenderer Blackness;

    public bool Aboolyy;

    private void Start()
    {
        CreateTheBlackness.letThereBeDark += ShowSteps;
    }

    private void Awake()
    {
        /*TheBlackness = GameObject.Find("TheBlackness");
        Blackness = TheBlackness.GetComponent<MeshRenderer>();
        Blackness.enabled = false;*/
        _controller = GetComponent<Meepy_CharacterController>();

    }

    public void ShowSteps()
    {
       // Debug.Log("Showing steps");

        StartCoroutine(Glowy());
        
    }

    IEnumerator Glowy()
    {
        for(int i = 1; i < 100000; i++)
        { 
        if (_controller.isGrounded)
        {
            Instantiate(Step, transform.position - LowerIt, Quaternion.identity);
            //Debug.Log("Glowy is on");

            //Aboolyy = false;
        }
        yield return new WaitForSeconds(0.25f);
        }
    }

    private void OnDisable()
    {
        CreateTheBlackness.letThereBeDark -= ShowSteps;
    }
    /* private void Update()
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
     }*/
}
