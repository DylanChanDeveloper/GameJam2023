using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreesAnim : MonoBehaviour
{
    private SpriteRenderer SR;

    public Sprite Idle;
    public Sprite Right;
    public Sprite Left;
    public Sprite Up;
    public Sprite Down;
    public float spriteTimer;
    public bool burnAndDie = false;
    

    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        spriteTimer += Time.deltaTime;
        if (spriteTimer >= 0.3f || burnAndDie == true)
        {
            SR.sprite = Idle;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || burnAndDie == true)
            {
            SR.sprite = Left;
            spriteTimer = 0;

        }
        if (Input.GetKeyDown(KeyCode.UpArrow) || burnAndDie == true)
        {
            SR.sprite = Up;
            spriteTimer = 0;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || burnAndDie == true)
        {
            SR.sprite = Down;
            spriteTimer = 0;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || burnAndDie == true)
        {
            SR.sprite = Right;
            spriteTimer = 0;
        }

        
        /*if (GameObject.Find("GameManager").GetComponent<GameManager>().MissedNotesHit == 3)
        {
        Destroy(rain3);
            burned3.SetActive(true);
        }*/

    }
}
