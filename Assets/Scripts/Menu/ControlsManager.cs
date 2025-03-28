using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsManager : MonoBehaviour
{
    public GameObject KeyboardControls;
    public GameObject ControllerText;
    public GameObject ControllerImage;
    public GameObject KeyboardToController;
    public GameObject ControllerToKeyboard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {

            KeyboardControls.SetActive(false);
            ControllerImage.SetActive(true);
            ControllerText.SetActive(true);
            ControllerToKeyboard.SetActive(true);
            KeyboardToController.SetActive(false);
            
        
        }
    }
}
