using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToTitleScreen() 
    {
        SceneManager.LoadScene(0);
    }
    public void GameQuit() 
    {
        Application.Quit();
    }
    public void ToMenu()
    {
        SceneManager.LoadScene(8);
    }
}
