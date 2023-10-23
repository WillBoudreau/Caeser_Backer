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
       
;   }

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
    public void InventoryMenuBUtton() 
    {
        paused = false;
        
    }
    public void InventoryBack() 
    {
        paused = true;
        
    }
    public void BackToTitleScreenButton()
    {
        SceneManager.LoadScene(0);
    }
}
