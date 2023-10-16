using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger3to2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerData.playerPOSX = -36;
        PlayerData.playerPOSY = -1;
        SceneManager.LoadScene(2);
    }
}
