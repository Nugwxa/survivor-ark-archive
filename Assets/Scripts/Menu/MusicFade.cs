using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicFade : MonoBehaviour
{
    public Animator BackgroundMusicFade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoTheDo()
    {
        BackgroundMusicFade.SetTrigger("FadeOut");
    }
}
