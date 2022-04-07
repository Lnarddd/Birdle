using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End_Screen_Win : MonoBehaviour
{
    [SerializeField] Text coins;
    [SerializeField] Text victorytext;

    // Start is called before the first frame update
    void Start()
    {
        coins.text = player_progress.money_earned.ToString() + "+";
        if(player_progress.req_wins < player_stats.wins){
            victorytext.text = "CHAMPION UNLOCKED!";
        }
    }

}
