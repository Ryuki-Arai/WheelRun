using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectBase : MonoBehaviour
{
    Rigidbody _rb;
    [SerializeField] UnityEvent<Collider> action;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        action.Invoke(other);
    }
}
