using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{


    [SerializeField] public GameObject SpawnEnemyPrefab;


    void Start()
    {
        for (int i = 0;i<5;i++){
            Spwan();
        }
 
    }

    void Spwan(){
        Instantiate(SpawnEnemyPrefab, new Vector3(Random.Range(-10.0f,10.0f),Random.Range(-10.0f,10.0f),0), Quaternion.identity);
    }


    public Vector2 RandomVector2(double angle, double angleMin){
        float random = Random.value * (float)angle + (float)angleMin;
        return new Vector3(Mathf.Cos(random), Mathf.Sin(random),0);
}

   
}
