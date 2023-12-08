using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossTrigger : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other != null)
        {
            PlayerData.NxtMnst = 66;
            SceneManager.LoadScene(5);
        }
    }

}
