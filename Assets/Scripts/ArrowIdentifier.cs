using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowIdentifier : MonoBehaviour
{
    public bool Pressable;

    public KeyCode keyPress;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyPress))
        {
            if (Pressable)
            {
                gameObject.SetActive(false);
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D myCollision)
    {
        if(myCollision.tag == "NoteTrigger")
        {
            Pressable = true;
        }
    }

    private void OnTriggerExit2D(Collider2D myCollision)
    {
        if (myCollision.tag == "NoteTrigger")
        {
            Pressable = false;
        }
    }
}
