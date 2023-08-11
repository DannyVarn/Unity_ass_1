using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   public GameObject effect;
   [SerializeField] public int damage = 25;

   void OnCollisionEnter2D(Collision2D collision)
   {
      GameObject eff = Instantiate(effect, transform.position, Quaternion.identity);
      Destroy(eff,5f);
      if (collision.gameObject.tag=="Enemy")
      {
         Enemy enemy = collision.gameObject.GetComponent<Enemy>();
         enemy.RecieveDamage(damage);
      }
      Destroy(gameObject); 
   }
}
