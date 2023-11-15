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
    string SaveValue;
    // Start is called before the first frame update

    public void SaveGame()
    {
        
        int CBposX = (int)math.round(PlayerData.playerPOSX);
        int CBposY = (int)math.round(PlayerData.playerPOSY);
        // "CBPScn","CBPEX","CBPVL","CBPSP","CBPST","CBPCN","CBPGI","CBPDX","CBPDV","CBPNL","CBPWI","CBPUK","CBPEX","CBPYE",    <- savedata format
        SaveValue = PlayerData.playerScene + "-" + PlayerData.CBXP + "-" + PlayerData.CBLVL + "-" + PlayerData.CBStatPoints + "-" + PlayerData.CBStr + "-" + PlayerData.CBCon + "-" + PlayerData.CBAgi + "-" + PlayerData.CBDex + "-" + PlayerData.CBDev + "-" + PlayerData.CBEnl + "-" + PlayerData.CBWill + "-" + PlayerData.CBLuck + "-" + CBposX + "-" + CBposY;

        File.WriteAllText(path, SaveValue);

     


        PlayerPrefs.Save();
        Debug.Log("Game data saved.");
    }
    public void LoadGame()
    {
        int SaveIndex = 0;
         SaveValue = File.ReadAllText(path);

         string[] LoadedData = SaveValue.Split('-');
         foreach (string SDValue in LoadedData)
         {
            DataLoad(SaveIndex, SDValue);
                
            SaveIndex = SaveIndex + 1;
         }



        Debug.Log("Game data loaded.");
        SceneManager.LoadScene(PlayerData.playerScene);
    }

    public void DataLoad(int Index, string Value)
    {
        if (Index == 0)
        {
            PlayerData.playerScene = Value;
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
            PlayerData.playerPOSX = float.Parse(Value);
        }
        else if (Index == 13)
        {
            PlayerData.playerPOSY = float.Parse(Value);
        }

    }
}


   

