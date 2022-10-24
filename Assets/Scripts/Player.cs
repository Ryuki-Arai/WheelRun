using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TouchScript.Gestures;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] int _speed = 5;
    Rigidbody _rb;
    [SerializeField]float[] lanes;
    int lane = 1;
    [SerializeField] float hp;
    int score = 0;
    [SerializeField] TextMeshProUGUI _tmp;
    [SerializeField] Slider _slider;

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
        _rb = GetComponent<Rigidbody>();
        _tmp.GetComponents<TextMeshProUGUI>();
        _slider.GetComponent<Slider>();
        _slider.maxValue = hp;
    }

    void FixedUpdate()
    {
        _rb.velocity = new Vector3(0, 0, 1) * _speed;
        if (hp < _slider.maxValue) hp += Time.deltaTime;
        _tmp.text = $"Score:{score}";
        _slider.value = hp;
    }

    public void Damage(int _damage)
    {
        Debug.Log("Damage");
        hp -= _damage;
    }

    public void ScoreUP(int _score)
    {
        Debug.Log("ScoreUP");
        score += _score;
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
        hp -= _slider.maxValue/10;
    }
}
