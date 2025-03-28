using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashScreen : MonoBehaviour
{
    public string loadLevel;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(loadLevel);
    }
}
