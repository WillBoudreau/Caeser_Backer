using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
    public bool paused = false;
    public GameObject InventoryMenu;
    public GameObject PauseMenu;
    // Start is called before the first frame update
    void Start()
    {
       InventoryMenu.SetActive(false);
       PauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void resume()
    {
        paused = false;
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
    }
    public void pauseButton() 
    {
        Time.timeScale = 0f;
        PauseMenu.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void InventoryMenuBUtton() 
    {
        InventoryMenu.SetActive(true);
        
    }
    public void InventoryBack() 
    {
        paused = true;
        InventoryMenu.SetActive(false);
    }
    public void BackToTitleScreenButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
