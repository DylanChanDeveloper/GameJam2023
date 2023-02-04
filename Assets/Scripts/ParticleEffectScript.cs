using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectScript : MonoBehaviour
{
    public float duration = 1f;

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, duration);
    }
}
