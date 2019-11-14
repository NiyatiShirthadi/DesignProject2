using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    public delegate void exitDoor();
    public static event exitDoor nextLevel;

    private void Start()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (nextLevel != null)
            {
                nextLevel();
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //EnterText.SetActive(true);
        }
    }
    /*private void OnTriggerExit2D(Collider2D collision)
    {
        EnterText.SetActive(false);
    }*/
    private void Update()
    {
       /* if(EnterText.activeInHierarchy)
        {
            if(Input.GetKey(KeyCode.Return))
            {
                
            }
        }*/
    }
}
