using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notificator : MonoBehaviour
{    
    public static Notificator instance;

    public delegate void message();
    public event message OnPressT;
    public event message OnCollideChest;
    public event message OnLookatChest;
    
    void Awake()
    {
        instance = this;
    }
    
    public Notificator GetInstance()
    {
        return instance;
    }

    public void InvokeOnCollideChest()
    {
        OnCollideChest();
    }
    public void InvokeOnLookatChest()
    {
        OnLookatChest();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            OnPressT();
        }
        if (Input.GetKey(KeyCode.R))
        {
            OnLookatChest();
        }
    }
}
