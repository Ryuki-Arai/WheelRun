using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : ObjectBase
{
    [SerializeField] public event Action<int> powerUP;
    [SerializeField] public int level;

    public override void Action()
    {
        powerUP += GameManager.Player.LevelUP;
        powerUP.Invoke(level);
        Destroy(gameObject);
    }
}
