using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    private Notificator notificator;
    public void Start()
    {
        notificator = Notificator.instance;
    }

    public void OnPointerEnter()
    {
        notificator.InvokeOnLookatChest();
    }

}