using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryButton : MonoBehaviour
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
    public void OpenIventory()
    {
        InventoryMenu.SetActive(true);
    }
    public void CloseInventory() 
    {
        InventoryMenu.SetActive(false);
    }
    public void BckToTtleScrn() 
    {
        SceneManager.LoadScene(0);
    }
    public void ResumeButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
}
