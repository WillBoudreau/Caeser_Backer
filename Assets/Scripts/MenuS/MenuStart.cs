using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuStart : MonoBehaviour
{
    public int MMSc;
    // Start is called before the first frame update
   public void ScnTrans()
    {
        PlayerData.CHKNBTL = true;
        PlayerData.playerPOSX = 0;
        PlayerData.playerPOSY = 0;
        PlayerData.CBLVL = 0;
        PlayerData.CBXP = 0;
        PlayerData.CBStatPoints = 0;
        PlayerData.CBWeaponBonus = 0;
        PlayerData.CBWeight = 0;
        PlayerData.CBDefense = 0;
        PlayerData.CBStr = 1;
        PlayerData.CBDex = 1;
        PlayerData.CBAgi = 1;
        PlayerData.CBCon = 1;    
        PlayerData.CBDev = 1;
        PlayerData.CBEnl = 1;
        PlayerData.CBWill = 1;
        PlayerData.CBLuck = 1;
        PlayerData.CBcHP = (PlayerData.CBCon * 5) + (PlayerData.CBStr * 3) + (PlayerData.CBWill * 2);
        PlayerData.CBmHP = (PlayerData.CBCon * 5) + (PlayerData.CBStr * 3) + (PlayerData.CBWill * 2);
        PlayerData.CBcSP = (PlayerData.CBDev * 5) + (PlayerData.CBEnl * 2);
        PlayerData.CBmSP = (PlayerData.CBDev * 5) + (PlayerData.CBEnl * 2);
        SceneManager.LoadScene(MMSc);
    }
}
