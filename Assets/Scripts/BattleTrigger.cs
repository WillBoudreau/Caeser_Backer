using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class BattleTrigger : MonoBehaviour
{
    public GameObject self;
    private float EncChance;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (PlayerData.HasBattled)
        {
            PlayerData.HasBattled = false;

        }
        else
        {
            if (collision != null)
            {
                PlayerData.playerPOSX = self.transform.position.x;
                PlayerData.playerPOSY = self.transform.position.y;
                EncChance = Random.Range(1, 5);
                PlayerData.NxtMnst = Random.Range(0,10);
                if (EncChance == 1 || EncChance == 5)
                {
                    PlayerData.HasBattled = true;
                    SceneManager.LoadScene(5);

                }
            }

        }
        
        
            
            
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
