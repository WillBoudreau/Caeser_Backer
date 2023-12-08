using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SaveNLoad : MonoBehaviour
{
    string path = @"CBATOUSD.txt";
    [SerializeField]string SaveValue;
    // Start is called before the first frame update
    [SerializeField]public int savePoint;
    public void SaveGame()
    {
        savePoint = PlayerData.playerScene;
        int CBposX = (int)math.round(PlayerData.playerPOSX);
        int CBposY = (int)math.round(PlayerData.playerPOSY);
        //float CBposX = PlayerData.playerPOSX;
        //float CBposY = PlayerData.playerPOSY;
        // "CBPScn","CBPEX","CBPVL","CBPSP","CBPST","CBPCN","CBPGI","CBPDX","CBPDV","CBPNL","CBPWI","CBPUK","CBPEX","CBPYE",    <- savedata format
        SaveValue = PlayerData.CBXP + "~" + PlayerData.CBLVL + "~" + PlayerData.CBStatPoints + "~" + PlayerData.CBStr + "~" + PlayerData.CBCon + "~" + PlayerData.CBAgi + "~" + PlayerData.CBDex + "~" + PlayerData.CBDev + "~" + PlayerData.CBEnl + "~" + PlayerData.CBWill + "~" + PlayerData.CBLuck;
        File.WriteAllText(path, SaveValue);

     


        
        Debug.Log("Game data saved.");
    }
    public void LoadGame()
    {
        int SaveIndex = 1;
         SaveValue = File.ReadAllText(path);

         string[] LoadedData = SaveValue.Split('~');
         foreach (string SDValue in LoadedData)
         {
            DataLoad(SaveIndex, SDValue);
                
            SaveIndex = SaveIndex + 1;
         }

        PlayerData.CBcHP = (PlayerData.CBCon * 5) + (PlayerData.CBStr * 3) + (PlayerData.CBWill * 2);
        PlayerData.CBmHP = (PlayerData.CBCon * 5) + (PlayerData.CBStr * 3) + (PlayerData.CBWill * 2);
        PlayerData.CBcAP = (PlayerData.CBDev * 5) + (PlayerData.CBEnl * 2);
        PlayerData.CBmAP = (PlayerData.CBDev * 5) + (PlayerData.CBEnl * 2);

        Debug.Log("Game data loaded.");
        PlayerData.playerPOSX = 0;
        PlayerData.playerPOSY = 0;
        SceneManager.LoadSceneAsync(0);
    }

    

    public void DataLoad(int Index, string Value)
    {
        if (Index == 0)
        {
            savePoint = int.Parse(Value);

        }
        else if (Index == 1)
        {
           PlayerData.CBXP = int.Parse(Value);
            
        }
        else if (Index == 2)
        {
            PlayerData.CBLVL = int.Parse(Value);
        }
        else if (Index == 3)
        {
            PlayerData.CBStatPoints = int.Parse(Value);
        }
        else if (Index == 4)
        {
            PlayerData.CBStr = int.Parse(Value);
        }
        else if (Index == 5)
        {
            PlayerData.CBCon = int.Parse(Value);
        }
        else if (Index == 6)
        {
            PlayerData.CBAgi = int.Parse(Value);
        }
        else if (Index == 7)
        {
            PlayerData.CBDex = int.Parse(Value);
        }
        else if (Index == 8)
        {
            PlayerData.CBDev = int.Parse(Value);
        }
        else if (Index == 9)
        {
            PlayerData.CBEnl = int.Parse(Value);
        }
        else if (Index == 10)
        {
            PlayerData.CBWill = int.Parse(Value);
        }
        else if (Index == 11)
        {
            PlayerData.CBLuck = int.Parse(Value);
        }
        else if (Index == 12)
        {
            PlayerData.playerPOSX = int.Parse(Value);
        }
        else if (Index == 13)
        {
            PlayerData.playerPOSY = int.Parse(Value);
        }

    }
}


   

