using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

    public string unitName;
    public int unitLevel;
    public int UnitXp;
    public int MnDamage;
    public int MxDamage;

    public int maxHP;
    public int currentHP;

    public bool TakeDamage(int mindmg, int maxdmg)
    {
        PlayerData.RNGRSLT = Random.Range(mindmg, maxdmg);
        currentHP -= PlayerData.RNGRSLT;

        if (currentHP == 0 | currentHP <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Heal(int amount)
    {
        currentHP += amount;
        if (currentHP > maxHP)
            currentHP = maxHP;
    }

}


