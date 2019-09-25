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
    public GameObject TheBlackness;

    public bool Aboolyy;

    /*[SerializeField]
    public bool StepIsOn {
        get
        {
            return SteppedOn;
        }
        set
        {
            SteppedOn = value;
            if(value == true)
            {
                Instantiate(Step, transform.position, Quaternion.identity);
            }
        }
    }*/
   /* IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(2f);
        if (Step != null)
        {
            Destroy(Step);
        }
    }*/

    private void Awake()
    {
        _controller = GetComponent<Meepy_CharacterController>();
    }
    private void Update()
    {
        if(TheBlackness.activeInHierarchy)
        { 
        if(Aboolyy == true && _controller.isGrounded)
        {
            Instantiate(Step, transform.position - LowerIt, Quaternion.identity);
           // StartCoroutine(SelfDestruct());
            Aboolyy = false;
        }
        }
    }
}
