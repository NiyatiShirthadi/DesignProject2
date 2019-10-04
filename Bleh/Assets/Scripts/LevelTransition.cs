using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    public GameObject EnterText;

    private void Start()
    {
        EnterText.SetActive(false); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            EnterText.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        EnterText.SetActive(false);
    }
    private void Update()
    {
        if(EnterText.activeInHierarchy)
        {
            if(Input.GetKey(KeyCode.Return))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
