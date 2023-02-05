using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager myInstance;
    public GameObject resultsScreen; 
    public AudioSource myAudio;
    public BeatPhysics myBP;

    public bool beginPlaying;

    public Text normalHitsText, MissedNotesText;
    public Text scoreText;
    public Text multiplierText;

    public int currentMultilpier;
    public int multiplierTracker;
    public int[] multiplierStacks;

    public int playerScore;
    public int scoreEarned = 10;

    public float normalHits;
    public float MissedNotesHit;

    //public float audioTimer;

    public GameObject destroyAudio;

    public GameObject hit;
    //public GameObject miss;
    public float hitAndMissTimer;

    public GameObject gameOver;
    public GameObject menuGameOver;
    public AudioSource gameOverSource;
    public AudioClip gameOverClip;
    //public bool isHit;




    // Start is called before the first frame update
    void Start()
    {
        myInstance = this;//the gamemanager will only have one instance
        scoreText.text = "Score: 0";
        currentMultilpier = 1;

      //  AllNotes = FindObjectsOfType<ArrowIdentifier>().Length;
    }

    // Update is called once per frame
    void Update()
    {
        hitAndMissTimer += Time.deltaTime;
        Debug.Log(hitAndMissTimer);
        if (hitAndMissTimer >= 0.3f)
        {
            hit.SetActive(false);

        }
        if (!beginPlaying)
        {
            if(Input.anyKeyDown)
            {
                beginPlaying = true;
                myBP.started = true;

                myAudio.Play();
            }
        }
        else
        {
            if(!myAudio.isPlaying && !resultsScreen.activeInHierarchy)
            {
                resultsScreen.SetActive(true);
                normalHitsText.text = "" + normalHits;
                MissedNotesText.text = "" + MissedNotesHit;
                Time.timeScale = 0;
            }
        }


        if (MissedNotesHit == 3)
        {
            Destroy(myAudio);
            gameOverSource.PlayOneShot(gameOverClip);
            resultsScreen.SetActive(true);
            menuGameOver.SetActive(true);
            Destroy(GameObject.Find("Rain").gameObject);
            normalHitsText.text = "" + normalHits;
            MissedNotesText.text = "" + MissedNotesHit;
            //Time.timeScale = 0;
            Destroy(gameOver);
            
        }
    }

    public void ArrowHit()
    {
        Debug.Log("hit");
        if (currentMultilpier - 1 < multiplierStacks.Length)
        {
            multiplierTracker++;

            if (multiplierStacks[currentMultilpier - 1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultilpier++;
                normalHits++;
            }
        }
        
        
    }

    public void ArrowHitMathsHandler()
    {
        multiplierText.text = "Score Multiplier: x" + currentMultilpier;

        playerScore += scoreEarned * currentMultilpier;
        scoreText.text = "Score:" + playerScore;
        
    }

    public void ArrowMissed()//for death handling too
    {
        //lose life handling here


        currentMultilpier = 1;
        multiplierTracker = 0;

        multiplierText.text = "Score Multiplier: x" + currentMultilpier;
        MissedNotesHit++;    
    }

}
