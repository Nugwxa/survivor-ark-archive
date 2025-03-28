using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuControls : MonoBehaviour
{

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuToControls()
    {
        anim.SetTrigger("MenuToControls");
    }

    public void ControlsToMenu()
    {
        anim.SetTrigger("ControlsToMenu");
    }

    public void MenuToPlay()
    {
        anim.SetTrigger("MenuToPlay");
    }

    public void PlayToMenu()
    {
        anim.SetTrigger("PlayToMenu");
    }
}
