using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject nontutorial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Tutorial()
    {
            tutorial.SetActive(true);
        nontutorial.SetActive(false);
    }
    public void Back()
    {
        tutorial.SetActive(false);
        nontutorial.SetActive(true);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Play()
    {
        SceneManager.LoadScene("Start");
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene("Start");
    }

    public void doExitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

}
