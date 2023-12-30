using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScieneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadScenes()
    {
        SceneManager.LoadScene("SampleScene");
        
    }
}
