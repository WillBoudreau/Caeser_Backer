using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatController : MonoBehaviour
{
    //status menu misc text
    public TextMeshProUGUI CharacterName;
    //status menu main stats
   
    
    public TextMeshProUGUI CurrentLevel02;
    public TextMeshProUGUI StatusPoints;
    public TextMeshProUGUI NextLvlExperiencePoints;
    //status menu core stats
    public TextMeshProUGUI StrValueText;
    public TextMeshProUGUI ConValueText;
    public TextMeshProUGUI AgiValueText;
    public TextMeshProUGUI DexValueText;
    public TextMeshProUGUI DevValueText;
    public TextMeshProUGUI EnlValueText;
    public TextMeshProUGUI WillValueText;
    public TextMeshProUGUI LuckValueText;
    
 
    // Start is called before the first frame update
    void Start()
    {
        int NxtLvl = (PlayerData.CBLVL + 1) * (314 / 50);

        CharacterName.text = PlayerData.CBName;
        //assignment of main stats to text boxes
        
        
        CurrentLevel02.text = "Lv. " + PlayerData.CBLVL;
        StatusPoints.text = PlayerData.CBStatPoints + "";
         ;
        NextLvlExperiencePoints.text = PlayerData.CBXP + " / " + NxtLvl;
        //assignment of stats to text boxes
        StrValueText.text = "" + PlayerData.CBStr;
        ConValueText.text = "" + PlayerData.CBCon;
        AgiValueText.text = "" + PlayerData.CBAgi;
        DexValueText.text = "" + PlayerData.CBDex;
        DevValueText.text = "" + PlayerData.CBDev;
        EnlValueText.text = "" + PlayerData.CBEnl;
        WillValueText.text = "" + PlayerData.CBWill;
        LuckValueText.text = "" + PlayerData.CBLuck;

    }

    // Update is called once per frame
    void Update()
    {
        //int NxtLvl = (PlayerData.CBLVL + 1) * (314 / 50);

        //CharacterName.text = PlayerData.CBName;
        ////assignment of main stats to text boxes


        //CurrentLevel02.text = "Lv. " + PlayerData.CBLVL;
        //StatusPoints.text = PlayerData.CBStatPoints + "";
        //;
        //NextLvlExperiencePoints.text = PlayerData.CBXP + " / " + NxtLvl;
        ////assignment of stats to text boxes
        //StrValueText.text = "" + PlayerData.CBStr;
        //ConValueText.text = "" + PlayerData.CBCon;
        //AgiValueText.text = "" + PlayerData.CBAgi;
        //DexValueText.text = "" + PlayerData.CBDex;
        //DevValueText.text = "" + PlayerData.CBDev;
        //EnlValueText.text = "" + PlayerData.CBEnl;
        //WillValueText.text = "" + PlayerData.CBWill;
        //LuckValueText.text = "" + PlayerData.CBLuck;
    }
    //buttons
    public void OnStrIncButton()
    {
        StatUp("Str");
        StrValueText.text = "" + PlayerData.CBStr;
        StatusPoints.text = PlayerData.CBStatPoints + "";
        PlayerData.CBmHP = (PlayerData.CBCon * 5) + (PlayerData.CBStr * 3) + (PlayerData.CBWill * 2);
        PlayerData.CBmAP = (PlayerData.CBDev * 5) + (PlayerData.CBEnl * 2);
    }
    public void OnConIncButton()
    {
        StatUp("Con");
        ConValueText.text = "" + PlayerData.CBCon;
        StatusPoints.text = PlayerData.CBStatPoints + "";
        PlayerData.CBmHP = (PlayerData.CBCon * 5) + (PlayerData.CBStr * 3) + (PlayerData.CBWill * 2);
        PlayerData.CBmAP = (PlayerData.CBDev * 5) + (PlayerData.CBEnl * 2);
    }
    public void OnAgiIncButton()
    {
        StatUp("Agi");
        AgiValueText.text = "" + PlayerData.CBAgi;
        StatusPoints.text = PlayerData.CBStatPoints + "";
        PlayerData.CBmHP = (PlayerData.CBCon * 5) + (PlayerData.CBStr * 3) + (PlayerData.CBWill * 2);
        PlayerData.CBmAP = (PlayerData.CBDev * 5) + (PlayerData.CBEnl * 2);
    }
    public void OnDexIncButton()
    {
        StatUp("Dex");
        DexValueText.text = "" + PlayerData.CBDex;
        StatusPoints.text = PlayerData.CBStatPoints + "";
        PlayerData.CBmHP = (PlayerData.CBCon * 5) + (PlayerData.CBStr * 3) + (PlayerData.CBWill * 2);
        PlayerData.CBmAP = (PlayerData.CBDev * 5) + (PlayerData.CBEnl * 2);
    }
    public void OnDevIncButton()
    {
        StatUp("Dev");
        DevValueText.text = "" + PlayerData.CBDev;
        StatusPoints.text = PlayerData.CBStatPoints + "";
        PlayerData.CBmHP = (PlayerData.CBCon * 5) + (PlayerData.CBStr * 3) + (PlayerData.CBWill * 2);
        PlayerData.CBmAP = (PlayerData.CBDev * 5) + (PlayerData.CBEnl * 2);
    }
    public void OnEnlIncButton()
    {
        StatUp("Enl");
        EnlValueText.text = "" + PlayerData.CBEnl;
        StatusPoints.text = PlayerData.CBStatPoints + "";
        PlayerData.CBmHP = (PlayerData.CBCon * 5) + (PlayerData.CBStr * 3) + (PlayerData.CBWill * 2);
        PlayerData.CBmAP = (PlayerData.CBDev * 5) + (PlayerData.CBEnl * 2);
    }
    public void OnWillIncButton()
    {
        StatUp("Will");
        WillValueText.text = "" + PlayerData.CBWill;
        StatusPoints.text = PlayerData.CBStatPoints + "";
        PlayerData.CBmHP = (PlayerData.CBCon * 5) + (PlayerData.CBStr * 3) + (PlayerData.CBWill * 2);
        PlayerData.CBmAP = (PlayerData.CBDev * 5) + (PlayerData.CBEnl * 2);
    }
    public void OnLuckIncButton()
    {
        StatUp("Luck");
        LuckValueText.text = "" + PlayerData.CBLuck;
        StatusPoints.text = PlayerData.CBStatPoints + "";
        PlayerData.CBmHP = (PlayerData.CBCon * 5) + (PlayerData.CBStr * 3) + (PlayerData.CBWill * 2);
        PlayerData.CBmAP = (PlayerData.CBDev * 5) + (PlayerData.CBEnl * 2);
    }
    //stat increase
    void StatUp(string stat)
    {
        if (PlayerData.CBStatPoints >= 1)
        {
            if (stat == "Str")
            {
                PlayerData.CBStr = PlayerData.CBStr + 1;
                PlayerData.CBStatPoints = PlayerData.CBStatPoints - 1;
            }
            else if (stat == "Con")
            {
                PlayerData.CBCon = PlayerData.CBCon + 1;
                PlayerData.CBStatPoints = PlayerData.CBStatPoints - 1;
            }
            else if (stat == "Agi")
            {
                PlayerData.CBAgi = PlayerData.CBAgi + 1;
                PlayerData.CBStatPoints = PlayerData.CBStatPoints - 1;
            }
            else if (stat == "Dex")
            {
                PlayerData.CBDex = PlayerData.CBDex + 1;
                PlayerData.CBStatPoints = PlayerData.CBStatPoints - 1;
            }
            else if (stat == "Dev")
            {
                PlayerData.CBDev = PlayerData.CBDev + 1;
                PlayerData.CBStatPoints = PlayerData.CBStatPoints - 1;
            }
            else if (stat == "Enl")
            {
                PlayerData.CBEnl = PlayerData.CBEnl + 1;
                PlayerData.CBStatPoints = PlayerData.CBStatPoints - 1;
            }
            else if (stat == "Will")
            {
                PlayerData.CBWill = PlayerData.CBWill + 1;
                PlayerData.CBStatPoints = PlayerData.CBStatPoints - 1;
            }
            else if (stat == "Luck")
            {
                PlayerData.CBLuck = PlayerData.CBLuck + 1;
                PlayerData.CBStatPoints = PlayerData.CBStatPoints - 1;
            }
            else
            {

            }
        }
        PlayerData.CBmHP = (PlayerData.CBCon * 5) + (PlayerData.CBStr * 3) + (PlayerData.CBWill * 2);
        
        PlayerData.CBmAP  = (PlayerData.CBDev * 5) + (PlayerData.CBEnl * 2);
    }
}
