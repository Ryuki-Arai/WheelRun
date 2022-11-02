using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSet : MonoBehaviour
{
    [SerializeField] int spawner;
    [SerializeField] int distance;
    string[] dir = {"L","C","R" };
    float[] posX = { -2f, 0f, 2f };
    void Start()
    {
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < spawner; j++)
            {
                var go = new GameObject($"Point{j}{dir[i]}");
                go.transform.parent = transform;
                go.transform.position = new Vector3(posX[i], 0.1f, j * distance + distance);
            }
        }
    }
}
