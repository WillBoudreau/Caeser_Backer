using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChickenBattleTrigger : MonoBehaviour
{
    [SerializeField] private Rigidbody2D PvLc;
    [SerializeField] private GameObject self;
    Vector2 XYpos;

    private void Start()
    {
        if (PlayerData.CHKNBTL == false)
        {
            self.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (PlayerData.CHKNBTL)
        {
            int Cscn = SceneManager.GetActiveScene().buildIndex;
            PlayerData.playerScene = Cscn;
            PvLc.position = new Vector2(XYpos.x, XYpos.y);
            PlayerData.playerPOSX = XYpos.x;
            PlayerData.playerPOSY = XYpos.y;
            PlayerData.CHKNBTL = false;
            SceneManager.LoadScene(5);
        }
        
    }
}
