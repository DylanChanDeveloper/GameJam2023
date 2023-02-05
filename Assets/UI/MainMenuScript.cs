using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject nontutorial;
    public GameObject menu;
    public GameObject back;
    public GameObject tutorialHowToBackGround;
    public AudioSource play;
    public AudioClip playClip;
    public AudioSource howTo;
    public AudioClip howToClip;
    public AudioSource quit;
    public AudioClip quitClip;

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
        howTo.PlayOneShot(howToClip);
        tutorial.SetActive(true);
        back.SetActive(true);
        nontutorial.SetActive(false);
        tutorialHowToBackGround.SetActive(true);
        menu.SetActive(false);
    }
    public void Back()
    {
        tutorial.SetActive(false);
        back.SetActive(false);
        nontutorial.SetActive(true);
        menu.SetActive(true);
        tutorialHowToBackGround.SetActive(false);
        quit.PlayOneShot(quitClip);
    }
    public void MainMenu()
    {
        //quit.PlayOneShot(quitClip);
        SceneManager.LoadScene("MainMenu");
        
    }

    public void Play()
    {

        //play.PlayOneShot(playClip);
        //Example();
        SceneManager.LoadScene("Start");
        
    }

    public void ReloadScene()
    {
        //play.PlayOneShot(playClip);
        SceneManager.LoadScene("Start");
        
    }

    public void doExitGame()
    {
        //quit.PlayOneShot(quitClip);
        Application.Quit();
        Debug.Log("Quit");
    }
    
    public void Awake()
    {
        DontDestroyOnLoad(GameObject.Find("Center").GetComponent<MainMenuScript>().play);
        DontDestroyOnLoad(GameObject.Find("Center").GetComponent<MainMenuScript>().quit);
        DontDestroyOnLoad(GameObject.Find("Center").GetComponent<MainMenuScript>().howTo); 
    }

}
