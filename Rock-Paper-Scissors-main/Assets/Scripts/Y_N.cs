using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR;

public class Y_N : MonoBehaviour
{
    public void Yes()
    {
        SceneManager.LoadScene("SampleScene"); // Reload current scene
    }

    public void No()
    {
        SceneManager.LoadScene("Start the game"); // Load the main scene
    }
}