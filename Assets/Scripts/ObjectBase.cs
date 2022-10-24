using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class ObjectBase : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Action();
    }
    public abstract void Action();
}
