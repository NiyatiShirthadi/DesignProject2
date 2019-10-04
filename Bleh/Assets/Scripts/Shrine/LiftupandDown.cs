using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftupandDown : MonoBehaviour
{
    public GameObject Player;
    public GameObject Lift;
    public GameObject LiftTopPos;
    private Vector3 _LiftStartPosition;
    

    private void Start()
    {
        _LiftStartPosition = Lift.transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Player.transform.parent = Lift.transform;
            //Lift.transform.position = Mathf.Lerp(Lift.transform.position, LiftTopPos.transform.position, Time.deltaTime);
            //Lift.transform.position = Vector3.Lerp(_LiftStartPosition, LiftTopPos.transform.position, Time.deltaTime);
            
        }
    }
}
