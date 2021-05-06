using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    // Loads a level called "name" which can be set/called from the Inspector Window
    // Can be called via a button press
    public void LoadLevel(string name)
    {
        Debug.Log("Level load requested for " + name);
        SceneManager.LoadScene(name);
        Time.timeScale = 1;
    }

    // Calls the QuitGame function which will exit the application
    // Note that this will not work in the case of an iOS app or in-browser version
    public void QuitGame()
    {
        Debug.Log("Quit game request received.");
        Application.Quit();
    }

    // Loads the next level/scene in the game 
    public void LoadNextLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}