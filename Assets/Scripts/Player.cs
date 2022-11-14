using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TouchScript.Gestures;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] int level = 0;
    public int Level => level;
    [SerializeField] int _speed = 5;
    Rigidbody _rb;
    [SerializeField]float[] lanes;
    int lane = 1;
    [SerializeField] float hp;
    int score = 0;
    [SerializeField] TMP_Text _tmp;
    [SerializeField] TMP_Text _tmpHp;
    [SerializeField] TMP_Text _tmpLevel;
    [SerializeField] Slider _slider;
    [SerializeField] int flickDamage;
 
    public FlickGesture flickGesture;

    private void Awake()
    {
        GameManager.Instance.SetPlayer(this);
    }
    private void OnEnable()
    {
        flickGesture.Flicked += OnFlicked;
    }

    private void OnDisable()
    {
        flickGesture.Flicked -= OnFlicked;
    }
    void Start()
    {
        score = 0;
        level = 1;
        _rb = GetComponent<Rigidbody>();
        _tmp.GetComponents<TMP_Text>();
        _tmpHp.GetComponents<TMP_Text>();
        _tmpLevel.GetComponent<TMP_Text>();
        _slider.GetComponent<Slider>();
        _slider.maxValue = hp;
    }

    void FixedUpdate()
    {
        _rb.velocity = new Vector3(0, 0, 1) * _speed;
        if (hp < _slider.maxValue) hp += (Time.deltaTime*10);
        _slider.value = hp;
        _tmpHp.text = ((int)(hp)).ToString();
        _tmp.text = $"Score:{score}";
        _tmpLevel.text = level.ToString();
    }

    public void Damage(int _damage)
    {
        hp -= _damage;
    }

    public void ScoreUP(int _score)
    {
        score += _score;
    }

    public void LevelUP(int _level)
    {
        level+=_level;
    }

    private void OnFlicked(object sender, EventArgs e)
    {
        MoveLane(flickGesture.ScreenFlickVector);
    }
    void MoveLane(Vector2 moveVec)
    {
        var move = moveVec.x;
        if (lane <= 0 && move < 0) return;
        if (lane >= lanes.Length - 1 && move > 0) return;
        if (move < 0) lane--;
        else if (move > 0) lane++;
        gameObject.transform.position = new Vector3(lanes[lane], gameObject.transform.position.y, gameObject.transform.position.z);
        hp -= flickDamage;
    }
}
