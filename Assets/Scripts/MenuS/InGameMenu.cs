using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
    public bool paused = false;
    public GameObject InventoryMenu;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        InventoryMenu.SetActive(false)
;    }

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
        Time.timeScale = 1f;
        SceneManager.LoadScene(8);
    }
    public void InventoryMenuBUtton() 
    {
        paused = false;
        InventoryMenu.SetActive(true);
    }
    public void InventoryBack() 
    {
        paused = true;
        InventoryMenu.SetActive(false);
    }
    public void BackToTitleScreenButton()
    {
        SceneManager.LoadScene(0);
    }
    public void ToMenuBUtton() 
    {
        
    }
}
