using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{

    public GameObject panelLvlComplete;

    bool gameEnded = false;

    public void winGame()
    {
        panelLvlComplete.SetActive(true);
    }
    public void endGame()
    {
        if (!gameEnded)
        {
            
            Invoke("restart", 2f);
        }
        
    }
    void Update()
    {
        if(pauseMenu.Paused)
        {
            FindObjectOfType<Camera>().GetComponent<AudioSource>().volume = 0.1f;
        }
        else
        {
            FindObjectOfType<Camera>().GetComponent<AudioSource>().volume = 0.3f;
        }

        if (Input.GetKey(KeyCode.Tab))
        {
            Cursor.visible = false;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Cursor.visible = true;
        }
    }
    void restart()
    {
        jumpTrigger.jumpZone = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
