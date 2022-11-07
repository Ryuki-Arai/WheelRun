using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] SpawnPos[] spawnPos;
    [System.Serializable]
    public class SpawnPos
    {
        public Transform[] linePos;
    }
    [SerializeField] GameObject coin;
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject obstacle;
    
    void Start()
    {
        for (int i = 0; i < spawnPos.Length; i++)
        {
            for (int j = 0; j < spawnPos[i].linePos.Length; j++)
            {
                Instantiate<GameObject>(coin, spawnPos[i].linePos[j]);
            }
        }
    }
}
