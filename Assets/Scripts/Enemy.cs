using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : ObjectBase
{
    [SerializeField] TMP_Text _levelText;
    [SerializeField] public event Action<int> Damage;
    [SerializeField] public event Action<int> scoreUP;
    int level;
    [SerializeField] int damage;
    [SerializeField] int score;

    private void Start()
    {
        _levelText.GetComponents<TMP_Text>();
        level = UnityEngine.Random.Range(1, 10);
        _levelText.text = level.ToString();
    }
    public override void Action()
    {
        if(GameManager.Player.Level < level)
        {
            Damage += GameManager.Player.Damage;
            Damage.Invoke(damage);
        }
        else
        {
            scoreUP += GameManager.Player.ScoreUP;
            scoreUP.Invoke(score);
            Destroy(gameObject);
        }
    }
}
