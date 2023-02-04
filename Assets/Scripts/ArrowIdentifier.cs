using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowIdentifier : MonoBehaviour
{
    public bool Pressable;
    public KeyCode keyPress;
   
    void Update()
    {
        if (Input.GetKeyDown(keyPress))
        {
            if (Pressable)
            {
                gameObject.SetActive(false);
                GameObject.Find("GameManager").GetComponent<GameManager>().normalHits++;
                GameObject.Find("GameManager").GetComponent<GameManager>().ArrowHitMathsHandler();

            }
        }       
    }

    private void OnTriggerEnter2D(Collider2D myCollision)
    {
        if(myCollision.tag == "NoteTrigger")
        {
            Pressable = true;
            GameManager.myInstance.ArrowHit();
        }
    }

    private void OnTriggerExit2D(Collider2D myCollision)
    {
        if (gameObject.activeSelf)
        {

            if (myCollision.tag == "NoteTrigger")
            {
                Pressable = false;
                GameManager.myInstance.ArrowMissed();
            }
        }
    }
}
