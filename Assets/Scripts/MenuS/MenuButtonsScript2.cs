using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonsScript2 : MonoBehaviour
{
    public GameObject optionsMenu;
    public GameObject Menu;
    public GameObject DevNotesMenu;
    // Start is called before the first frame update
    void Start()
    {
        optionsMenu.SetActive(false);
        DevNotesMenu.SetActive(false);
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
    public void OptionsbackButton()
    {
        optionsMenu.SetActive(false);
        Menu.SetActive(true);

    }
    public void quitButton()
    {
        Application.Quit();
    }
    public void DevNotesButton()
    {
        DevNotesMenu.SetActive(true);
        Menu.SetActive(false);
    }
    public void DevNotesBack()
    {
        DevNotesMenu.SetActive(false);
        Menu.SetActive(true);
    }
}
