using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public static bool Paused = false;
    public GameObject pauseMenuUi;

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }


    }

    public void resume()
    {
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }

    void pause()
    {
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
    }

    public void menu()
    {
        Paused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");

    }
    public void quit()
    {
        Application.Quit();
    }
}
