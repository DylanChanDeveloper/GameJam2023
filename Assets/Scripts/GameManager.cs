using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager myInstance;

    public AudioSource myAudio;

    public bool beginPlaying;

    public BeatPhysics myBP;
    // Start is called before the first frame update
    void Start()
    {
        myInstance = this;//the gamemanager will only have one instance
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
    }

    public void ArrowMissed()
    {
        Debug.Log("missed");
    }
}
