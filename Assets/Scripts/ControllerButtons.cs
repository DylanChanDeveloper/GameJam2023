using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerButtons : MonoBehaviour
{
    private SpriteRenderer mySR;

    public Sprite currentImage;
    public Sprite overlapImage;

    public KeyCode keyPress;
    // Start is called before the first frame update
    void Start()
    {
        mySR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyPress))
        {
            mySR.sprite = overlapImage;
        }

        if (Input.GetKeyUp(keyPress))
        {
            mySR.sprite = currentImage;
        }
    }
}
