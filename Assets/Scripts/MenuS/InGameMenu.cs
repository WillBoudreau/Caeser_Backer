using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
    public GameObject InventoryMenu;
    public GameObject inGameMenu;
    public GameObject StatMenu;
    public GameObject CharacterImage;
    public GameObject Needtofindfix1;
    public GameObject NeedtoFindfix2;
    // Start is called before the first frame update
    void Start()
    {
       InventoryMenu.SetActive(false);
       inGameMenu.SetActive(false);
       StatMenu.SetActive(false);
        CharacterImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void toMenu()
    {
        inGameMenu.SetActive(true);
        CharacterImage.SetActive(true) ;
        Time.timeScale = 0.0f;
    }
    public void resume()
    {
        Time.timeScale = 1f;
        inGameMenu.SetActive(false );
        CharacterImage.SetActive(false) ;
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
        CharacterImage.SetActive(false) ;
        NeedtoFindfix2.SetActive(false);
        Needtofindfix1 .SetActive(false);
    }
    public void InventoryBack() 
    {
        
        InventoryMenu.SetActive(false);
        CharacterImage.SetActive(true) ;
        Needtofindfix1.SetActive(true);
        NeedtoFindfix2 .SetActive(true);
    }
    public void BackToTitleScreenButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void StatButton()
    {
       StatMenu.SetActive(true);
        CharacterImage.SetActive(false) ;
    }
    public void BackStat()
    {
        StatMenu.SetActive(false);
        CharacterImage.SetActive(true);
    }
}
