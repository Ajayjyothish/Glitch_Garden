using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    [SerializeField] float loadLevelDelay = 2f;

    public void Start()
    {
        Invoke("loadNextScene", loadLevelDelay);
    }

    public void loadNextScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);


    }

    public void loadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void loadLevelString(string level)
    {
        SceneManager.LoadScene(level);


    }

    public void exit()
    {
        
        Application.Quit();
    }

    
}
