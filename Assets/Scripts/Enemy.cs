using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : ObjectBase
{
    public override void Action()
    {
        Destroy(gameObject);
    }
}
