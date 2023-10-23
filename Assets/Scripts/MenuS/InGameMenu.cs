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
       InventoryMenu.SetActive(false);
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
        SceneManager.LoadScene(0);
    }
}
