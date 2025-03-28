using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeControl : MonoBehaviour
{

    public GameObject GrenadeObject;
    public GameObject ExplosionParticle;
    public GameObject ExplosionSound;
    public GameObject DamageStuff;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(3f);
        Destroy(GrenadeObject);
        ExplosionParticle.SetActive(true);
        ExplosionSound.SetActive(true);
        DamageStuff.SetActive(true);        
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
