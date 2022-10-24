using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coin : ObjectBase
{
    [SerializeField] public event Action<int> scoreUP;
    [SerializeField] int score;
    public override void Action()
    {
        scoreUP += GameManager.Player.ScoreUP;
        scoreUP.Invoke(score);
        Destroy(gameObject);
    }
}
