using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public void StartGame()
    {
        // Code to start the game (replace with your game's logic)
        SceneManager.LoadScene("SampleScene"); // Load the main scene
    }

    public void ExitGame()
    {
        // Code to exit the game
        Application.Quit();
    }
}