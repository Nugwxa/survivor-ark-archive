﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayToMenu : MonoBehaviour
{

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButtonDown("Return"))
        {
            Debug.Log("A$$");
            anim.SetTrigger("PlayToMenu");
        }

    }
}
