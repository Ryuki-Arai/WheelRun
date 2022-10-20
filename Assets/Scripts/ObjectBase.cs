using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class ObjectBase : MonoBehaviour
{
    [SerializeField] UnityEvent action;

    private void OnTriggerEnter(Collider other)
    {
        action.Invoke();
        Action();
    }
    public abstract void Action();
}
