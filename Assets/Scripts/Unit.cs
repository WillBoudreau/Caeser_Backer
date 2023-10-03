using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string UnitName;
    public int UnitLevel;
    public int Damage;
    public int MaxHP;
    public int CurrentHP;
    public int Armour;
    public bool TakeDamage(int dmg)
    {
        CurrentHP -= ((dmg * 4) - Armour) % 4;

        if(CurrentHP <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
    
}
