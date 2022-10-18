using System;
using System.Collections;
using System.Collections.Generic;
using TouchScript.Gestures;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] int _speed = 5;
    Rigidbody _rb;
    int balance = 0;
    public int Balance => balance;
    [SerializeField]float[] lanes;
    int lane = 1;
    [SerializeField] int hp;
    int score;

    public FlickGesture flickGesture;
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
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        _rb.velocity = new Vector3(0, 0, 1) * _speed;
    }

    public void Damage(int _damage)
    {
        Debug.Log("Damage");
    }

    public void ScoreUP(int _score)
    {
        Debug.Log("ScoreUP");
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
    }
}
