using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialBegin : MonoBehaviour
{
    public GameObject CurrentItem;
    public GameObject PauseMenu;
    public EnemyManager EnemyManager;
    public UserInput UserInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {

            CurrentItem.SetActive(false);
            PauseMenu.SetActive(true);
            EnemyManager.enabled = true;
            UserInput.enabled = true;

        }
    }
}
