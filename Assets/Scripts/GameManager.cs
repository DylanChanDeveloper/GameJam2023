using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager myInstance;

    public AudioSource myAudio;

    public bool beginPlaying;

    public BeatPhysics myBP;

    public int playerScore;
    public int scoreGain = 10;

    public Text scoreText;
    public Text multiplierText;

    public int currentMultilpier;
    public int multilierTracker;
    public int[] multiplierThresholds;


    // Start is called before the first frame update
    void Start()
    {
        myInstance = this;//the gamemanager will only have one instance

        scoreText.text = "Score: 0";
        currentMultilpier = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (!beginPlaying)
        {
            if(Input.anyKeyDown)
            {
                beginPlaying = true;
                myBP.started = true;

                myAudio.Play();
            }
        }
    }

    public void ArrowHit()
    {
        Debug.Log("hit");
        if (currentMultilpier - 1 < multiplierThresholds.Length)
        {
            multilierTracker++;

            if (multiplierThresholds[currentMultilpier - 1] <= multilierTracker)
            {
                multilierTracker = 0;
                currentMultilpier++;
            }
        }

        multiplierText.text = "Score Multiplier: x" + currentMultilpier;

        playerScore += scoreGain * currentMultilpier;
        scoreText.text = "Score:" + playerScore;
    }

    public void ArrowMissed()
    {
        //lose life handling here
        Debug.Log("missed");

       currentMultilpier = 1;
        multilierTracker = 0;


        multiplierText.text = "Score Multiplier: x" + currentMultilpier;
    }
}
