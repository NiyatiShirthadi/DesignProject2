using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectThePlayer : MonoBehaviour
{
    public bool playerDetected;
    public float playerRayDistance;

    public GameObject Path;
    private SpriteRenderer PathMesh;

    private void Start()
    {
        PathMesh = Path.GetComponent<SpriteRenderer>();
        PathMesh.enabled = false;
    }
    IEnumerator DetectingPlayer()
    {
        RaycastHit2D playerDetection = Physics2D.Raycast(transform.position, Vector2.down, playerRayDistance);

        if (playerDetection.collider.tag == "Player")
        {
           // Debug.Log("player has been sighted");
            playerDetected = true;
        }
        else
        {
            playerDetected = false;
        }
        yield return new WaitForSeconds(0f);
    }
    // Start is called before the first frame update
    private void Update()
    {
        StartCoroutine(DetectingPlayer());

        if(playerDetected == true)
        {
            PathMesh.enabled = true;
        }
        

    }
}
