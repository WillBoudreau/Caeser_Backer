using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
    public bool paused = false;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pauseButton() 
    {
        paused = true;
        Time.timeScale = 0f;
        SceneManager.LoadScene(8);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Resume() 
    {
        paused = false;

    }
}
