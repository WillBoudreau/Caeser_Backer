using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelFix : MonoBehaviour
{
    public TextMeshProUGUI CurrentLevel01; // this needs to be here for updating one of the text boxes properly
    // Start is called before the first frame update
    void Start()
    {
        CurrentLevel01.text = "Lv. " + PlayerData.CBLVL; // this also needs to be here for updating one of the text boxes properly
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
