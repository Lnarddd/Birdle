using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Endurance_Minigame_Endscreen : MonoBehaviour
{
    
    [SerializeField] Text experiencegained;
    [SerializeField] Text overtext;
    private int experiencegain;

    void Start()
    {
        if(player_progress.level == 1 && player_stats.endurance < 25){
            player_progress.score_endurance = player_progress.score_endurance * 0.75f * 2;
            experiencegain = (int)player_progress.score_endurance;
            player_progress.LevelEndurance(experiencegain);
            experiencegained.text = player_progress.prog_endurance.ToString() + "/" + player_progress.req_endurance.ToString();
            Debug.Log(player_progress.prog_endurance.ToString() + "/" + player_progress.req_endurance.ToString());
            overtext.text = "Level " + player_stats.endurance.ToString();
        }
        else if(player_progress.level == 2 && player_stats.endurance < 45){
            player_progress.score_endurance = player_progress.score_endurance * 0.85f * 2;
            experiencegain = (int)player_progress.score_endurance;
            player_progress.LevelEndurance(experiencegain);
            experiencegained.text = player_progress.prog_endurance.ToString() + "/" + player_progress.req_endurance.ToString();
            overtext.text = "Level " + player_stats.endurance.ToString();
        }
        else if(player_progress.level == 3 && player_stats.endurance < 65){
            player_progress.score_endurance = player_progress.score_endurance * 0.95f * 2;
            experiencegain = (int)player_progress.score_endurance;
            player_progress.LevelEndurance(experiencegain);
            experiencegained.text = player_progress.prog_endurance.ToString() + "/" + player_progress.req_endurance.ToString();
            overtext.text = "Level " + player_stats.endurance.ToString();
        }
        else if(player_progress.level == 4 && player_stats.endurance <  99){
            player_progress.score_endurance = player_progress.score_endurance * 1 * 2;
            experiencegain = (int)player_progress.score_endurance;
            player_progress.LevelEndurance(experiencegain);
            experiencegained.text = player_progress.prog_endurance.ToString() + "/" + player_progress.req_endurance.ToString();
            overtext.text = "Level " + player_stats.endurance.ToString();
        }
        else{
            overtext.text = "ALREADY REACHED THE MAX LEVEL FOR THIS STAGE";
        }
    }

    public void returnscene(){
        SceneManager.LoadScene(2);
        player_progress.score_endurance = 0;
    }

    public void retrylevel(){
        if(player_progress.level == 1){
            SceneManager.LoadScene("Endurance_Minigame_1");
            player_progress.score_endurance = 0;
        }
        else if(player_progress.level == 2){
            SceneManager.LoadScene("Endurance_Minigame_2");
            player_progress.score_endurance = 0;
        }
        else if(player_progress.level == 3){
            SceneManager.LoadScene("Endurance_Minigame_3");
            player_progress.score_endurance = 0;
        }
        else if(player_progress.level == 4){
            SceneManager.LoadScene("Endurance_Minigame_4");
            player_progress.score_endurance = 0;
        }
    }
}
