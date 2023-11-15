using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SaveNLoad : MonoBehaviour
{


    // Start is called before the first frame update

    public void SaveGame()
    {

        PlayerPrefs.SetInt("CBPScn", PlayerData.playerScene);
        PlayerPrefs.SetInt("CBPEX", PlayerData.CBXP);
        PlayerPrefs.SetInt("CBPVL", PlayerData.CBLVL);
        PlayerPrefs.SetInt("CBPSP", PlayerData.CBStatPoints);
        PlayerPrefs.SetInt("CBPST", PlayerData.CBStr);
        PlayerPrefs.SetInt("CBPCN", PlayerData.CBCon);
        PlayerPrefs.SetInt("CBPGI", PlayerData.CBAgi);
        PlayerPrefs.SetInt("CBPDX", PlayerData.CBDex);
        PlayerPrefs.SetInt("CBPDV", PlayerData.CBDev);
        PlayerPrefs.SetInt("CBPNL", PlayerData.CBEnl);
        PlayerPrefs.SetInt("CBPWI", PlayerData.CBWill);
        PlayerPrefs.SetInt("CBPUK", PlayerData.CBLuck);
        PlayerPrefs.SetFloat("CBPEX", PlayerData.playerPOSX);
        PlayerPrefs.SetFloat("CBPYE", PlayerData.playerPOSY);


        PlayerPrefs.Save();
        Debug.Log("Game data saved.");
    }
    public void LoadGame()
    {
        
            PlayerData.playerScene = PlayerPrefs.GetInt("CBPScn");
            PlayerData.CBXP = PlayerPrefs.GetInt("CBPEX");
            PlayerData.CBLVL = PlayerPrefs.GetInt("CBPVL");
            PlayerData.CBStatPoints = PlayerPrefs.GetInt("CBPSP");
            PlayerData.CBStr = PlayerPrefs.GetInt("CBPST");
            PlayerData.CBCon = PlayerPrefs.GetInt("CBPCN");
            PlayerData.CBAgi = PlayerPrefs.GetInt("CBPGI");
            PlayerData.CBDex = PlayerPrefs.GetInt("CBPDX");
            PlayerData.CBDev = PlayerPrefs.GetInt("CBPDV");
            PlayerData.CBEnl = PlayerPrefs.GetInt("CBPNL");
            PlayerData.CBWill = PlayerPrefs.GetInt("CBPWI");
            PlayerData.CBLuck = PlayerPrefs.GetInt("CBPUK");
            PlayerData.playerPOSX = PlayerPrefs.GetFloat("CBPEX");
            PlayerData.playerPOSY = PlayerPrefs.GetFloat("CBPYE");


            Debug.Log("Game data loaded.");
        SceneManager.LoadScene(PlayerData.playerScene);
    }
}


   

