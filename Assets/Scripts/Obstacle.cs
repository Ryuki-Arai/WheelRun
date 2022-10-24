using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : ObjectBase
{
    [SerializeField] public event Action<int> Damage;
    [SerializeField] int damage;
    public override void Action()
    {
        Damage += GameManager.Player.Damage;
        Damage.Invoke(damage);
    }
}
