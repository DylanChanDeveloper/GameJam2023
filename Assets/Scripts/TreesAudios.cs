using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreesAudios : MonoBehaviour
{

    public AudioSource Left;
    public AudioClip LeftClip;
    public AudioSource Right;
    public AudioClip RightClip;
    public AudioSource Up;
    public AudioClip UpClip;
    public AudioSource Down;
    public AudioClip DownClip;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && GameObject.Find("GameManager").GetComponent<GameManager>().MissedNotesHit != 3)
        {
            Left.PlayOneShot(LeftClip);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && GameObject.Find("GameManager").GetComponent<GameManager>().MissedNotesHit != 3)
        {
            Right.PlayOneShot(RightClip);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && GameObject.Find("GameManager").GetComponent<GameManager>().MissedNotesHit != 3)
        {
            Up.PlayOneShot(UpClip);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && GameObject.Find("GameManager").GetComponent<GameManager>().MissedNotesHit != 3)
        {
            Down.PlayOneShot(DownClip);
        }
    }
}
