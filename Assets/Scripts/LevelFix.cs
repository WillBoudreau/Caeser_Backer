using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelFix : MonoBehaviour
{
    public TextMeshProUGUI HealthPoints;
    public TextMeshProUGUI ApostlePoints;
    public TextMeshProUGUI CurrentLevel01; // this needs to be here for updating one of the text boxes properly
    // Start is called before the first frame update
    void Start()
    {
        
         // this also needs to be here for updating one of the text boxes properly
    }

    // Update is called once per frame
    void Update()
    {
        HealthPoints.text = PlayerData.CBcHP + " / " + PlayerData.CBmHP;
        ApostlePoints.text = PlayerData.CBcSP + " / " + PlayerData.CBmSP;
        CurrentLevel01.text = "Lv. " + PlayerData.CBLVL;
    }
}
