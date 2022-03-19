using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCalculator
{
 public static bool TakeDamage(int dmg, int currentHP)
 {
  currentHP -= dmg;

  if(currentHP <= 0)
      return true;
  else
      return false;
 
 }

 public static int Heal(int amount, int maxHP, int currentHP)
 {
  currentHP += amount;

  if(currentHP > maxHP)
      currentHP = maxHP;

  return currentHP;
 }
}
