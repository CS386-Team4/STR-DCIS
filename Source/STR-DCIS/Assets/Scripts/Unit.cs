using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string unitName;
    public int unitLevel;

    public int damage;
    public int maxHP;
    public int currentHP;  

    public bool TakeDamage(int dmg)
    {
        currentHP -= dmg;
        return HealthCalc.DamageCalculator(currentHP);
    }

    public void Heal(int amount)
    {
        currentHP += amount;
        currentHP = HealthCalc.HealCalculator(currentHP, maxHP);
    }
}

public static class HealthCalc
{   
    public static bool DamageCalculator(int currentHP)
    {
        if(currentHP <= 0)
            return true;
        else
            return false;
    }

    public static int HealCalculator(int currentHP, int maxHP)
    {
        if(currentHP > maxHP)
            return maxHP;
        else
            return currentHP;
    }
}