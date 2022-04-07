using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_progress : MonoBehaviour
{    
    public static int level = 4;
    public static int prog_strength;
    public static int prog_agility;
    public static int prog_endurance;
    public static int req_wins;
    public static int req_strength = 100;
    public static int req_agility = 100;
    public static int req_endurance = 100;
    public static bool player_ready;

    public static bool tutorial_shop;
    public static bool tutorial_menu;
    public static bool tutorial_training;
    public static bool tutorial_battle;

    //Minigame Score Data storing
    public static int score_strength;
    public static float score_agility;
    public static float score_endurance;
    public static int money_earned;


    public static void LevelStrength(int exp){
        if(req_strength > prog_strength ){
            prog_strength += exp;
            exp = prog_strength - req_strength;
        } 

        if(req_strength <= prog_strength ){
            float req_strength_float = (float)req_strength * 1.12f;
            req_strength = (int)req_strength_float;
            prog_strength = 0;
            if(exp > req_strength){
                LevelStrength(exp);
            }
            else{
                prog_strength += exp;
            }    
            player_stats.strength += 1;
        }
    }

    public static void LevelAgility(int exp){
        if(req_agility > prog_agility ){
            prog_agility += exp;
            exp = prog_agility - req_agility;
        } 

        if(req_agility <= prog_agility ){
            float req_agility_float = (float)req_agility * 1.12f;
            req_agility = (int)req_agility_float;
            prog_agility = 0;
            if(exp > req_agility){
                LevelAgility(exp);
            }
            else{
                prog_agility += exp;
            } 
            player_stats.speed += 1;
        }
    }

    public static void LevelEndurance(int exp){
        if(req_endurance > prog_endurance ){
            prog_endurance += exp;
            exp = prog_endurance - req_endurance;
        } 

        if(req_endurance <= prog_endurance ){
            float req_endurance_float = (float)req_endurance * 1.12f;
            req_endurance = (int)req_endurance_float;
            prog_endurance = 0;
            if(exp > req_endurance){
                LevelEndurance(exp);
            }
            else{
                prog_endurance += exp;
            } 
            player_stats.endurance += 1;
        }
    }
}
