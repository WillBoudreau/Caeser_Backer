using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class BattleHUD : MonoBehaviour
{

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI levelText;
    public Slider hpSlider;
    public Slider ApSlider;

    public void SetHUD(Unit unit)
    {
        nameText.text = unit.unitName;
        levelText.text = "LvL : " + unit.unitLevel;
        hpSlider.maxValue = unit.maxHP;
        hpSlider.value = unit.currentHP;
        ApSlider.maxValue = unit.maxAP;
        ApSlider.value = unit.currentAP;
    }

    public void SetHP(int hp, int ap)
    {
        hpSlider.value = hp;
        ApSlider.value = ap;

    }

}
