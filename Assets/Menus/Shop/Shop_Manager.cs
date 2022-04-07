using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop_Manager : MonoBehaviour
{
    [SerializeField] Text coins_text;

    void Update()
    {
        coins_text.text = player_stats.cash.ToString() + " Coins";
    }
}
