using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    bool menuOpen;
    public GameObject pauseMenu;


    private void Start()
    {
        menuOpen = false;
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetButtonDown("Pause"))
        {
            PauseGame();
        }
    }

    void PauseGame()
    {

        pauseMenu.SetActive(menuOpen);

        if (menuOpen)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        menuOpen = !menuOpen;

    }

    public void TogglePause()
    {
        PauseGame();
    }
}
