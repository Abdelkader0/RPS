using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public void Continue_play()
    {
        SceneManager.LoadScene("SampleScene");
            }
    public void B_Restart()
    {
        // Code to start the game (replace with your game's logic)
        SceneManager.LoadScene("Y_N"); // Load the main scene
    }
    public void ExitGame()
    {
        // Code to exit the game
        SceneManager.LoadScene("Start the game");
    }
}
