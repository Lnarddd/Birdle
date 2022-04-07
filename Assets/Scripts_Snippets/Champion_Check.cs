using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Champion_Check : MonoBehaviour
{
    [SerializeField] Button battle_champion;
    // Start is called before the first frame update

    void Start()
    {
        if(player_progress.req_wins <= player_stats.wins){
            battle_champion.interactable = true;
    
        }
        else{
            battle_champion.interactable = false;
        }
    }
}
