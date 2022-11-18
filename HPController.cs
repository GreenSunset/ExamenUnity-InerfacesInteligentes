using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPController : MonoBehaviour
{
    public BeholderEvents Player;
    private Scrollbar HPBar;
    void Start()
    {
        HPBar = GetComponent<Scrollbar>();
    }
    void Update()
    {
        HPBar.size = Player.HP / 100f;
        if (Player.HP > 60)
        {
            HPBar.colors = new ColorBlock() { normalColor = Color.green, colorMultiplier = 1f };
        } else if (Player.HP > 40)
        {
            HPBar.colors = new ColorBlock() { normalColor = Color.yellow, colorMultiplier = 1f };
        } else if (Player.HP > 20)
        {
            HPBar.colors = new ColorBlock() { normalColor = new Color(1f,.5f,0f), colorMultiplier = 1f };
        } else if (Player.HP > 0)
        {
            HPBar.colors = new ColorBlock() { normalColor = Color.red, colorMultiplier = 1f };
        } else
        {
            HPBar.colors = new ColorBlock() { normalColor = Color.black, colorMultiplier = 0f };
            Debug.Log("You are dead");
        }
    }
}
