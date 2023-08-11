using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    [SerializeField] public Transform shootingPoint;
    [SerializeField] public GameObject bullet;
    public float bulletForce = 20f;
   

    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject b = Instantiate(bullet,shootingPoint.position,shootingPoint.rotation);
        Rigidbody2D rb = b.GetComponent<Rigidbody2D>();
        rb.AddForce(shootingPoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
