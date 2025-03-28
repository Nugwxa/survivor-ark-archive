using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerToKeyboardMenu : MonoBehaviour
{
    public GameObject KeyboardControls;
    public GameObject ControllerText;
    public GameObject ControllerImage;
    public GameObject ControllerToKeyboard;
    public GameObject KeyboardToController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            
                ControllerImage.SetActive(false);
                ControllerText.SetActive(false);
            KeyboardControls.SetActive(true);
            //KeyboardImage.SetActive(true);
            //KeyboardText.SetActive(true);
            KeyboardToController.SetActive(true);
                ControllerToKeyboard.SetActive(false);
                
        
        }
    }
}
