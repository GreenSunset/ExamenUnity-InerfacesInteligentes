using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSpiderSetup : MonoBehaviour
{
    private Notificator notificator;
    public float rotationSpeed = 1f;
    void Start()
    {
        notificator = Notificator.instance;
        notificator.OnLookatChest += Rotate;
    }

    void Rotate()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }
}
