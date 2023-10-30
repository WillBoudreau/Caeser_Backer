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
        PlayerData.CBcHP = 50;
        PlayerData.CBmHP = 50;
        PlayerData.CBmnDMG = 1;
        PlayerData.CBmxDMG = 2;
        PlayerData.CBLVL = 0;
        PlayerData.CBcSP = 10;
        PlayerData.CBmSP = 10;
        PlayerData.CBXP = 0;
        SceneManager.LoadScene(MMSc);
    }
}
