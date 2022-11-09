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
            var rand = Random.Range(0, spawnPos[i].linePos.Length);
            if ((i + 1) % 5 == 0)
            {
                for (int j = 0; j < spawnPos[i].linePos.Length; j++)
                {
                    if (j == rand) Instantiate<GameObject>(coin, spawnPos[i].linePos[j]);
                    else Instantiate<GameObject>(enemy, spawnPos[i].linePos[j]);
                }
                continue;
            }
            for (int j = 0; j < spawnPos[i].linePos.Length; j++)
            {
                if(j == rand) Instantiate<GameObject>(obstacle, spawnPos[i].linePos[j]);
                else Instantiate<GameObject>(coin, spawnPos[i].linePos[j]);
            }
        }
    }
}
