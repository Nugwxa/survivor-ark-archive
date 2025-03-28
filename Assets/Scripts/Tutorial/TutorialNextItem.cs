using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialNextItem : MonoBehaviour
{
    public GameObject CurrentItem;
    public GameObject NextItem;
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
            NextItem.SetActive(true);

        }

    }
}
