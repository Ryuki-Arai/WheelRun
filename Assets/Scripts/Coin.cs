using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coin : ObjectBase
{
    public override void Action()
    {
        Destroy(gameObject);
    }
}
