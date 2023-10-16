using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonsScript : MonoBehaviour
{
    public GameObject optionsMenu;
    public GameObject Menu;
    // Start is called before the first frame update
    void Start()
    {
        optionsMenu.SetActive(false);

        Menu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void optionButton()
    {
        optionsMenu.SetActive(true);
        Menu.SetActive(false);
    }
    public void backButton()
    {
        optionsMenu.SetActive(false);
        Menu.SetActive(true);
    }
    public void quitButton()
    {
        Application.Quit();
    }
}
