using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtinActivate : MonoBehaviour
{
    private Color Temp;

    public GameObject startButton;
    public GameObject quitButton;
    // Start is called before the first frame update
    void Start()
    {
        BlacknessFadeIn.tisDark += activateButton;

        startButton.SetActive(false);
        quitButton.SetActive(false);
        
    }

    public void activateButton()
    {
        startButton.SetActive(true);
        quitButton.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
       
        Application.Quit();
    }

    private void OnDisable()
    {
        BlacknessFadeIn.tisDark -= activateButton;
    }
}
