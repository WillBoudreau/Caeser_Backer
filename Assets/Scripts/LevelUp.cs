using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour
{
    
    public static bool LVLUP()
    {
        if (PlayerData.CBXP >= ((PlayerData.CBLVL + 1) * (314 / 50)))
        {
            while (PlayerData.CBXP >= ((PlayerData.CBLVL + 1) * (314 / 50)))
            {
            PlayerData.CBXP = PlayerData.CBXP - (PlayerData.CBLVL * (314 / 50));
            PlayerData.CBLVL = PlayerData.CBLVL + 1;
            PlayerData.CBStatPoints = PlayerData.CBStatPoints + (PlayerData.CBLVL * (157 / 100));
            }
            return true;
        }
        else
        {
            return false;
        }
    }

   
}
