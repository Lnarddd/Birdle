using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Strength_Minigame_EndScreen : MonoBehaviour
{

    [SerializeField] Text experiencegained;
    [SerializeField] Text overtext;
    private int experiencegain;

    // Start is called before the first frame update
    void Start()
    {
        if(player_progress.level == 1 && player_stats.strength < 25){
            experiencegain = player_progress.score_strength * 50;
            player_progress.LevelStrength(experiencegain);
            experiencegained.text = player_progress.prog_strength.ToString() + "/" + player_progress.req_strength.ToString();
            overtext.text = "Level " + player_stats.strength.ToString();
        }
        else if(player_progress.level == 2 && player_stats.strength < 45){
            experiencegain = player_progress.score_strength * 75;
            player_progress.LevelStrength(experiencegain);
            experiencegained.text = player_progress.prog_strength.ToString() + "/" + player_progress.req_strength.ToString();
            overtext.text = "Level " + player_stats.strength.ToString();
        }
        else if(player_progress.level == 3 && player_stats.strength < 65){
            experiencegain = player_progress.score_strength * 80;
            player_progress.LevelStrength(experiencegain);
            experiencegained.text = player_progress.prog_strength.ToString() + "/" + player_progress.req_strength.ToString();
            overtext.text = "Level " + player_stats.strength.ToString();
        }
        else if(player_progress.level == 4 && player_stats.strength < 99){
            experiencegain = player_progress.score_strength * 90;
            player_progress.LevelStrength(experiencegain);
            experiencegained.text = player_progress.prog_strength.ToString() + "/" + player_progress.req_strength.ToString();
            overtext.text = "Level " + player_stats.strength.ToString();
        }
        else{
            overtext.text = "ALREADY REACHED THE MAX LEVEL FOR THIS STAGE";
        }
    }

    public void returnscene(){
        SceneManager.LoadScene("Minigame_Selector");
        player_progress.score_agility = 0;
    }

    public void retrylevel(){
        if(player_progress.level == 1){
            SceneManager.LoadScene("Strength_Minigame_level_1");
            player_progress.score_agility = 0;
        }
        else if(player_progress.level == 2){
            SceneManager.LoadScene("Strength_Minigame_level_2");
            player_progress.score_agility = 0;
        }
        else if(player_progress.level == 3){
            SceneManager.LoadScene("Strength_Minigame_level_3");
            player_progress.score_agility = 0;
        }
        else if(player_progress.level == 4){
            SceneManager.LoadScene("Strength_Minigame_level_4");
            player_progress.score_agility = 0;
        }
    }

}
