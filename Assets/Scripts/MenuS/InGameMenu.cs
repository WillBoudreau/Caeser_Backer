using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
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
    public void resume()
    {
        
        Time.timeScale = 1f;
        PlayerData.playerPOSX;
        PlayerData.playerPOSY;
        SceneManager.LoadScene(2);
    }
    public void pauseButton() 
    {
        Time.timeScale = 0f;
       
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
        
        InventoryMenu.SetActive(false);
    }
    public void BackToTitleScreenButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
