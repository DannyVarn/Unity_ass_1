using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  [SerializeField] public int HP;
  [SerializeField] public int maxHP;
  [SerializeField] public float speed = 3f;
  public float distance;
  [SerializeField] public GameObject p;
  [SerializeField] public float discoverDistance;
  [SerializeField] public float attackDistance;
  public HP_Bar healthbar;
  [SerializeField] public int damage;
  public Player player;
  private float NextFire;
  private float attackRate = 2f;


  void Start()
  {
    player = FindObjectOfType<Player>();
    HP = maxHP;
    healthbar = GetComponentInChildren<HP_Bar>();
  }
  void Update()
  {
    distance = Vector2.Distance(transform.position, player.gameObject.transform.position);
    if (distance < discoverDistance)
    {
      transform.position = Vector2.MoveTowards(this.transform.position,player.gameObject.transform.position,speed*Time.deltaTime);
    }
    if (distance <attackDistance && Time.time>NextFire)
    {
      player.RecieveDamage(damage);
      NextFire = Time.time + attackRate;
    }
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

  void die(){
    Destroy(gameObject);
  }



}
