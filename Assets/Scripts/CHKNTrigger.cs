using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CHKNTrigger : MonoBehaviour
{
    public bool ChknFight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null && ChknFight)
        {
            PlayerData.NxtMnst = 1;
            ChknFight = false;
            SceneManager.LoadScene(5);
        }
    }
}
