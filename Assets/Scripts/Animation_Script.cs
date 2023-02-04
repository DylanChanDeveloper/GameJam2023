using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Script : MonoBehaviour
{
    public GameObject burned1;
    public GameObject rain1;
    public GameObject burned2;
    public GameObject rain2;
    public GameObject burned3;
    public GameObject rain3;
    private bool burned1true = false;
    private bool burned2true = false;
    private bool burned3true = false;
    private float timer;
    public GameObject dead1;
    public GameObject dead2;
    public GameObject dead3;

    void Update()
    {
        timer += Time.deltaTime;

        if (GameObject.Find("GameManager").GetComponent<GameManager>().MissedNotesHit == 1)
        {
            Destroy(rain1);
            burned1.SetActive(true);
            dead1.SetActive(true);
            burned1true = true;
            timer = 0;

}

        
            

        if (GameObject.Find("GameManager").GetComponent<GameManager>().MissedNotesHit == 2)
        {
            Destroy(rain2);
            burned2.SetActive(true);
            dead2.SetActive(true);
            burned2true = true;
            timer = 0;
        }
        
            

        if (GameObject.Find("GameManager").GetComponent<GameManager>().MissedNotesHit == 3)
        {
            Destroy(rain3);
            burned2.SetActive(true);
                dead3.SetActive(true);
                burned3true = true;
            timer = 0;
        }
        
            

    }
}
