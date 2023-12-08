using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossTrigger : MonoBehaviour
{

    public void OnTriggerEnter (Collider other)
    {
        if (other != null)
        {
            PlayerData.NxtMnst = 66;
            SceneManager.LoadScene(5);
        }
    }

}
