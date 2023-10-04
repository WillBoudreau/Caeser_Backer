using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class BTLHuD : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI NameText;
    public TextMeshProUGUI LevelText;
    public Slider HPSlider;

    public void SetHuD(Unit unit)
    {
        NameText.Te = unit.UnitName;
        LevelText.text = "LvL: " + unit.UnitLevel;
        HPSlider.maxValue = unit.MaxHP;
        HPSlider.value = unit.CurrentHP;
    }


    public void SetHP(int Hp)
    {
        HPSlider.value = Hp;
    }
}
