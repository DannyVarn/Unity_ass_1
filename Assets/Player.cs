using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

  [SerializeField] public int HP=300;
  [SerializeField] public int maxHP=300;
  public HP_Bar healthbar;


  void Start()
  {
    HP = maxHP;
    healthbar = GetComponentInChildren<HP_Bar>();
  }
  public void RecieveDamage(int dmg)
  {
    HP -= dmg;
    healthbar.UpdateHPBar((float)HP,(float)maxHP);
    if (HP <= 0)
    {
      die();
    }
  }

  void die()
  {
    Destroy(gameObject);
    Application.Quit();
  }

}
