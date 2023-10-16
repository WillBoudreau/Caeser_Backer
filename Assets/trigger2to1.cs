using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trigger2to1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerData.playerPOSX = 4;
        PlayerData.playerPOSY = -1;
        SceneManager.LoadScene(1);
    }

}
