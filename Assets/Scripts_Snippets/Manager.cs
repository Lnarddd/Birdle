using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {


    public void strength_load_level(){
        if(player_progress.level == 1){
            SceneManager.LoadScene("Strength_Minigame_level_1");
        }
        else if(player_progress.level == 2){
            SceneManager.LoadScene("Strength_Minigame_level_2");
        }
        else if(player_progress.level == 3){
            SceneManager.LoadScene("Strength_Minigame_level_3");
        }
        else if(player_progress.level == 4){
            SceneManager.LoadScene("Strength_Minigame_level_4");
        }
    }

    public void agility_load_level(){
        if(player_progress.level == 1){
            SceneManager.LoadScene("Agility_Minigame_1");
        }
        else if(player_progress.level == 2){
            SceneManager.LoadScene("Agility_Minigame_2");
        }
        else if(player_progress.level == 3){
            SceneManager.LoadScene("Agility_Minigame_3");
        }
        else if(player_progress.level == 4){
            SceneManager.LoadScene("Agility_Minigame_4");
        }
    }

    public void endurance_load_level(){
        if(player_progress.level == 1){
            SceneManager.LoadScene("Endurance_Minigame_1");
        }
        else if(player_progress.level == 2){
            SceneManager.LoadScene("Endurance_Minigame_2");
        }
        else if(player_progress.level == 3){
            SceneManager.LoadScene("Endurance_Minigame_3");
        }
        else if(player_progress.level == 4){
            SceneManager.LoadScene("Endurance_Minigame_4");
        }
    }

    public void train_load_level(){
        SceneManager.LoadScene("Minigame_Selector");
    }

    public void battlescene_load_level(){
        SceneManager.LoadScene("Battle_Menu");
    }

    public void battlescene_boss_load_level(){
        SceneManager.LoadScene("Battle_Menu_Boss");
    }

    public void gamemenu_load_level(){
        SceneManager.LoadScene("Game_Menu");
    }

    public void game_main_menu(){
        SceneManager.LoadScene("Main_menu");
    }

    public void surrender(){
        SceneManager.LoadScene("End_Screen_Loss");
    }

    public void char_creator(){
        SceneManager.LoadScene("Player_Custom");
    }
    
    public void boss_load_level(){
        switch(player_progress.level){
                case 1:
                    SceneManager.LoadScene("Boss_Scene_1");
                    break;
                case 2:
                    SceneManager.LoadScene("Boss_Scene_2");
                    break;
                case 3:
                    SceneManager.LoadScene("Boss_Scene_3");
                    break;
                case 4:
                    SceneManager.LoadScene("Boss_Scene_4");
                    break;
            }
    }

    public void Shop_Load(){
        switch(player_progress.level){
                case 1:
                    SceneManager.LoadScene("Shop_Level_1");
                    break;
                case 2:
                    SceneManager.LoadScene("Shop_Level_2");
                    break;
                case 3:
                    SceneManager.LoadScene("Shop_Level_3");
                    break;
                case 4:
                    SceneManager.LoadScene("Shop_Level_4");
                    break;
            }
    }

    public void Cutscenes(){
        switch(player_progress.level){
                case 1:
                    SceneManager.LoadScene("Cutscene_1");
                    break;
                case 2:
                    SceneManager.LoadScene("Cutscene_2");
                    break;
                case 3:
                    SceneManager.LoadScene("Cutscene_3");
                    break;
                case 4:
                    SceneManager.LoadScene("Cutscene_4");
                    break;
            }
    }

}
