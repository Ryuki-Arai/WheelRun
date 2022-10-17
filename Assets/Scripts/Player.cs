using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int _speed = 5;
    Rigidbody _rb;
    int balance = 0;
    public int Balance => balance;
    [SerializeField]float[] lanes;
    int lane = 1;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        MoveLane((int)Input.GetAxisRaw("Horizontal"));

        _rb.velocity = new Vector3(0, 0, 1) * _speed;
    }

    void MoveLane(int move)
    {
        if (lane <= 0 && move < 0) return;
        if (lane >= lanes.Length - 1 && move > 0) return;
        lane += move;
        gameObject.transform.position = new Vector3(lanes[lane], gameObject.transform.position.y, gameObject.transform.position.z);
    }
}
