using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using UnityEngine.SceneManagement;

public class BattleTrigger : MonoBehaviour
{
    private float EncTime;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        EncTime = Random.Range(100, 1000);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (EncTime > count)
        {
            count = count + 1;
        }
        else
        {
            
            if (collision != null)
            {
                PlayerData.NxtMnst = Random.Range(0,10);
                SceneManager.LoadScene(5);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
