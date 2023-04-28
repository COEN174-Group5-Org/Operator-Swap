using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Function is called whenever the play button is pressed
    public void PlayGame ()
    {
        // Load the next scene of the game
        SceneManager.LoadScene("Gameplay_1");
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
