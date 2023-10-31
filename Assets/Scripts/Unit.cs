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
    public int Accuracy;
    public int Evasion;

    public int maxHP;
    public int currentHP;
    public bool Hit;

    public bool TakeDamage(int mindmg, int maxdmg, int Acc)
    {
        int HitRate = Random.Range(Acc, 100);
        if (HitRate > Evasion)
        {
            Hit = true;
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
        else
        {
            Hit = false;
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


