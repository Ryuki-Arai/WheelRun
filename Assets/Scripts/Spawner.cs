using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Transform[] spawnPos;
    [SerializeField] GameObject coin;
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject obstacle;
    
    void Start()
    {
        for(int i = 0; i < spawnPos.Length; i++)
        {
            var x = Random.Range(0,100);
            if (x > 80) Instantiate<GameObject>(obstacle, spawnPos[i]);
            else if (x > 50) Instantiate<GameObject>(enemy, spawnPos[i]);
            else Instantiate<GameObject>(coin, spawnPos[i]);
        }
    }
}
