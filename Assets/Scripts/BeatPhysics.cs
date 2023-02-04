using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatPhysics : MonoBehaviour
{
    public float BPM;
    public bool started;

    // Start is called before the first frame update
    void Start()
    {
        BPM = BPM / 60F;
    }

    // Update is called once per frame
    void Update()
    {
        if (!started)
        {
           /* if (Input.anyKeyDown)
            {
                started = true;
            }      */     
        }
        else
        {
            transform.position -= new Vector3(0f, BPM * Time.deltaTime, 0f);
        }
    }
}
