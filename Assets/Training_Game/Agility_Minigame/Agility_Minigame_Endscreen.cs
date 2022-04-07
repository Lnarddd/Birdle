using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Agility_Minigame_Endscreen : MonoBehaviour
{

    [SerializeField] Text experiencegained;
    [SerializeField] Text overtext;
    private int experiencegain;

    void Start()
    {
        if(player_progress.level == 1 && player_stats.speed < 25){
            player_progress.score_agility = player_progress.score_agility * 0.75f * 2;
            experiencegain = (int)player_progress.score_agility;
            player_progress.LevelAgility(experiencegain);
            experiencegained.text = player_progress.prog_agility.ToString() + "/" + player_progress.req_agility.ToString();
            overtext.text = "Level " + player_stats.speed.ToString();
        }
        else if(player_progress.level == 2 && player_stats.speed < 45){
            player_progress.score_agility = player_progress.score_agility * 0.85f * 2;
            experiencegain = (int)player_progress.score_agility;
            player_progress.LevelAgility(experiencegain);
            experiencegained.text = player_progress.prog_agility.ToString() + "/" + player_progress.req_agility.ToString();
            overtext.text = "Level " + player_stats.speed.ToString();
        }
        else if(player_progress.level == 3 && player_stats.speed < 65){
            player_progress.score_agility = player_progress.score_agility * 0.95f * 2;
            experiencegain = (int)player_progress.score_agility;
            player_progress.LevelAgility(experiencegain);
            experiencegained.text = player_progress.prog_agility.ToString() + "/" + player_progress.req_agility.ToString();
            overtext.text = "Level " + player_stats.speed.ToString();
        }
        else if(player_progress.level == 4 && player_stats.speed < 99){
            player_progress.score_agility = player_progress.score_agility * 1 * 2;
            experiencegain = (int)player_progress.score_agility;
            player_progress.LevelAgility(experiencegain);
            experiencegained.text = player_progress.prog_agility.ToString() + "/" + player_progress.req_agility.ToString();
            overtext.text = "Level " + player_stats.speed.ToString();
        }
        else{
            overtext.text = "ALREADY REACHED THE MAX LEVEL FOR THIS STAGE";
        }
    }

    public void returnscene(){
        SceneManager.LoadScene(2);
        player_progress.score_agility = 0;
    }

    public void retrylevel(){
        if(player_progress.level == 1){
            SceneManager.LoadScene("Agility_Minigame_1");
            player_progress.score_agility = 0;
        }
        else if(player_progress.level == 2){
            SceneManager.LoadScene("Agility_Minigame_2");
            player_progress.score_agility = 0;
        }
        else if(player_progress.level == 3){
            SceneManager.LoadScene("Agility_Minigame_3");
            player_progress.score_agility = 0;
        }
        else if(player_progress.level == 4){
            SceneManager.LoadScene("Agility_Minigame_4");
            player_progress.score_agility = 0;
        }
    }
}

