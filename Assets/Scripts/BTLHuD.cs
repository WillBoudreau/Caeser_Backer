using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BTLHuD : MonoBehaviour
{
    // Start is called before the first frame update
    public Text NameText;
    public Text LevelText;
    public Slider HPSlider;

    public void SetHuD(Unit unit)
    {
        NameText.text = unit.UnitName;
        LevelText.text = "LvL: " + unit.UnitLevel;
        HPSlider.maxValue = unit.MaxHP;
        HPSlider.value = unit.CurrentHP;
    }


    public void SetHP(int Hp)
    {
        HPSlider.value = Hp;
    }
}
