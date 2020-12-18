using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//needed

public class RetryQuit : MonoBehaviour
{

    //replay scene
    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //quit game
    public void QuitGame()
    {
        Application.Quit();
    }
}
