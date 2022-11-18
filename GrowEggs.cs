using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowEggs : MonoBehaviour
{
    private Notificator notificator;
    public float growthFactor = 1.2f;
    void Start()
    {
        notificator = Notificator.instance;
        notificator.OnCollideChest += Grow;
    }

    void Grow()
    {
        transform.localScale *= growthFactor;
    }
}
