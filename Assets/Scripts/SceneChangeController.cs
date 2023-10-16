using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeController : MonoBehaviour
{
    public int TposX;
    public int TposY;

    public int SCNL;
    // Start is called before the first frame update
    void Start()
    {

        

        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            PlayerData.playerPOSX = TposX;
            PlayerData.playerPOSY = TposY;
            SceneManager.LoadScene(SCNL);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
