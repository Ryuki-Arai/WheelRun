using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : ObjectBase
{
    [SerializeField] public event Action<int> Damage;
    [SerializeField] public event Action<int> scoreUP;
    [SerializeField] int damage;
    [SerializeField] int score;
    public override void Action()
    {
        Damage += GameManager.Player.Damage;
        Damage.Invoke(damage);
        Destroy(gameObject);
    }
}
