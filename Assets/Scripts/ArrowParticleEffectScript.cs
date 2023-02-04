using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowParticleEffectScript : MonoBehaviour
{
    public GameObject RedPe, GreenPe;
    public static ArrowParticleEffectScript ArrowParticleEffectScriptInstance;
    // Start is called before the first frame update
    void Start()
    {
        ArrowParticleEffectScriptInstance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void particleInstantiateHit()
    {
        Instantiate(GreenPe, transform.position, GreenPe.transform.rotation);
    }

    public void particleInstantiateHitMiss()
    {
        Instantiate(RedPe, transform.position, RedPe.transform.rotation);
    }
}
