using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public static PauseMenu Instance;




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
                Resume();
            else
                Pause();
        }


    }

    void Awake()
    {
        Instance = this;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
    }

    public void pauseGame()
    {
        if (GameIsPaused)
        {
            //Time.timeScale = 1;
            //GameIsPaused = false;
            Resume();
        } else
        {
            //Time.timeScale = 0;
           // GameIsPaused = true;
            Pause();
        }
            
        
    }

 
   

    public void QuitGame()
    {
        Application.Quit();
    }
}
