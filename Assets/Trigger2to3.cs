using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger2to3 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerData.playerPOSX = -32;
        PlayerData.playerPOSY = -1;
        SceneManager.LoadScene(3);
    }
}
