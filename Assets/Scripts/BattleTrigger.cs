using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class BattleTrigger : MonoBehaviour
{
    public GameObject self;
    
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        PlayerData.EncChanceMax = Random.Range(5, 25);
        PlayerData.EncChance = 1;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
        
            int Cscn = SceneManager.GetActiveScene().buildIndex;
            
            

            
            PlayerData.NxtMnst = Random.Range(0, 10);
            if (Flipper(PlayerData.EncChanceMax, PlayerData.EncChance) == 0)
            {
                PlayerData.playerScene = Cscn;
                PlayerData.playerPOSX = self.transform.position.x;
                PlayerData.playerPOSY = self.transform.position.y;
                SceneManager.LoadScene(5);

            }
            else
            {
                PlayerData.EncChance = Flipper(PlayerData.EncChanceMax, PlayerData.EncChance); 
            }

        }
        
        
        




    }
    private int Flipper(int Mvalue, int Cvalue)
    {
        if (Cvalue >= Mvalue)
        {
            return 0;
        }
        else if (Cvalue == 0)
        {
            
            Cvalue = Cvalue + 1;
            return Cvalue;
        }
        else
        {
            Cvalue = Cvalue + 1;
            return Cvalue;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
