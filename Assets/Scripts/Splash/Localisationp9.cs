using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Localisationp9 : MonoBehaviour
{

    public int nextScene;
    public Animator Click;
    public int sceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clicker()
    {
        StartCoroutine(Clicked(sceneIndex));
    }

    IEnumerator Clicked(int sceneIndex)
    {

        Click.SetTrigger("Clicked");

        yield return new WaitForSeconds(5f);

        

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);


    }
}
