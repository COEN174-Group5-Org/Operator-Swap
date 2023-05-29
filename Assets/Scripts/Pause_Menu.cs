// Even though this is the "Pause_Menu" Script, it's really the canvas overlay script

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public static bool GameIsPaused = false; 
    public static bool GameIsOver = false; // when success or defeat is triggered, set this boolean to true
    // to use this boolean: 
    // if(Pause_Menu.GameIsPaused){ ... }

    public GameObject pauseMenuUI;
    public GameObject pauseButton; 
    public GameObject successScreenUI;
    public GameObject defeatScreenUI;

    public Player_Values pl;

    // Update is called once per frame
    void Update()
    {
        
        if (!GameIsOver)
        {
            if(Input.GetKeyDown(KeyCode.Escape)){
                if(GameIsPaused)
                {
                    Resume();
                }else{
                    Pause();
                }
            }
        }
    }

    void Start(){
        pl = GameObject.Find("Canvas").GetComponent<Player_Values>();
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
        pl.Set_Is_Paused(false);
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true; 
        pl.Set_Is_Paused(true);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        //Debug.Log("Loading menu...");
        SceneManager.LoadScene("Title_menu");
    }

    public void success()
    {
        GameIsOver = true; 
        pauseButton.SetActive(false);
        successScreenUI.SetActive(true);
    }

    public void defeat()
    {
        GameIsOver = true; 
        pauseButton.SetActive(false);
        defeatScreenUI.SetActive(true);
    }

}
