using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Not_Target_Practice : MonoBehaviour
{
    private void OnMouseDown() {
        GameObject.Find("GameControl").GetComponent<Strength_Minigame_1>().spawntargets += 1;
        GameObject.Find("GameControl").GetComponent<Strength_Minigame_1>().PlayWrong();
        if(player_progress.score_strength > 0){
            player_progress.score_strength -= 1;
        }
        Destroy(gameObject);   
    }
    public void KillSelf() {
        Destroy(gameObject); 
    }
}
