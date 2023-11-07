using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using UnityEngine.SceneManagement;

public class BattleTrigger : MonoBehaviour
{
    private float EncChance;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        
        
        if (collision != null)
        {
            
            EncChance = Random.Range(1, 5);
            PlayerData.NxtMnst = Random.Range(0,10);
            if (EncChance == 1 || EncChance == 5)
            {
                SceneManager.LoadScene(5);

            }
        }
        
            
            
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
