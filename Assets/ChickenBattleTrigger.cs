using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChickenBattleTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerData.playerPOSX = -21;
        PlayerData.playerPOSY = -1;
        if (PlayerData.CHKNBTL)
        {
            PlayerData.CHKNBTL = false;
            SceneManager.LoadScene(5);
        }
        
    }
}
