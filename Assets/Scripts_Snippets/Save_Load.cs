using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;

public class Save_Load : MonoBehaviour
{
    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/player_data.bird")){
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/player_data.bird", FileMode.Open);
            PlayerData_Storage data = (PlayerData_Storage)bf.Deserialize(file);

            player_stats.bird_name = data.bird_name;
            player_stats.cash = data.cash;
            player_stats.speed = data.speed;
            player_stats.strength = data.strength;
            player_stats.endurance = data.endurance;
            player_stats.wins = data.wins;
            player_stats.loss = data.loss;
            player_stats.item_1 = data.item_1;
            player_stats.item_2 = data.item_2;
            player_stats.item_2_unlocked = data.item_2_unlocked;
            player_stats.items = data.items;
            player_stats.red = data.red;
            player_stats.green = data.green;
            player_stats.blue = data.blue;

            player_progress.level = data.level;
            player_progress.prog_strength = data.prog_strength;
            player_progress.prog_agility = data.prog_agility;
            player_progress.prog_endurance = data.prog_endurance;
            player_progress.req_wins = data.req_wins;
            player_progress.req_strength = data.req_strength;
            player_progress.req_agility = data.req_agility;
            player_progress.req_endurance = data.req_endurance;
            player_progress.tutorial_shop = data.tutorial_shop;
            player_progress.tutorial_menu = data.tutorial_menu;
            player_progress.tutorial_training = data.tutorial_training;
            player_progress.tutorial_battle= data.tutorial_battle; 

            file.Close();
        }
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/player_data.bird");
        PlayerData_Storage data = new PlayerData_Storage();

        data.bird_name = player_stats.bird_name;
        data.cash = player_stats.cash;
        data.speed = player_stats.speed;
        data.strength = player_stats.strength;
        data.endurance = player_stats.endurance;
        data.wins = player_stats.wins;
        data.loss = player_stats.loss;
        data.item_1 = player_stats.item_1;
        data.item_2 = player_stats.item_2;
        data.item_2_unlocked = player_stats.item_2_unlocked;
        data.items = player_stats.items;
        data.red = player_stats.red;
        data.green = player_stats.green;
        data.blue = player_stats.blue;

        data.level = player_progress.level;
        data.prog_strength = player_progress.prog_strength;
        data.prog_agility = player_progress.prog_agility;
        data.prog_endurance = player_progress.prog_endurance;
        data.req_wins = player_progress.req_wins;
        data.req_strength = player_progress.req_strength;
        data.req_agility = player_progress.req_agility;
        data.req_endurance = player_progress.req_endurance;
        data.tutorial_shop = player_progress.tutorial_shop;
        data.tutorial_menu = player_progress.tutorial_menu;
        data.tutorial_training = player_progress.tutorial_training;
        data.tutorial_battle = player_progress.tutorial_battle; 

        bf.Serialize(file, data);
        file.Close();
    }

    public void New_game(){
        if (File.Exists(Application.persistentDataPath + "/player_data.bird")){
            SceneManager.LoadScene("New_Game_Screen");
        }
        else{
            player_stats.cash = 0;
            player_stats.speed = 1;
            player_stats.strength = 1;
            player_stats.endurance = 1;
            player_stats.wins = 0;
            player_stats.loss = 0;
            player_stats.item_1 = null;
            player_stats.item_2 = null;
            player_stats.item_2_unlocked = false;
            player_stats.items.Clear();
            
            player_progress.level = 1;
            player_progress.prog_strength = 0;
            player_progress.prog_agility = 0;
            player_progress.prog_endurance = 0;
            player_progress.req_wins = 10;
            player_progress.req_strength = 100;
            player_progress.req_agility = 100;
            player_progress.req_endurance = 100;
            player_progress.tutorial_shop = false;
            player_progress.tutorial_menu = false;
            player_progress.tutorial_training = false;
            player_progress.tutorial_battle = false; 
            
            Save();
        }
    }

    public void Forced_New(){
            player_stats.cash = 0;
            player_stats.speed = 1;
            player_stats.strength = 1;
            player_stats.endurance = 1;
            player_stats.wins = 0;
            player_stats.loss = 0;
            player_stats.item_1 = null;
            player_stats.item_2 = null;
            player_stats.item_2_unlocked = false;
            player_stats.items.Clear();

            player_progress.level = 1;
            player_progress.prog_strength = 0;
            player_progress.prog_agility = 0;
            player_progress.prog_endurance = 0;
            player_progress.req_wins = 10;
            player_progress.req_strength = 100;
            player_progress.req_agility = 100;
            player_progress.req_endurance = 100;
            player_progress.tutorial_shop = false;
            player_progress.tutorial_menu = false;
            player_progress.tutorial_training = false;
            player_progress.tutorial_battle = false; 
            
            Save();
    }
}

[Serializable]
class PlayerData_Storage
{
    public string bird_name;
    public int cash;
    public int speed;
    public int strength;
    public int endurance;
    public int wins;
    public int loss;
    public string item_1;
    public string item_2;
    public bool item_2_unlocked;
    public List<string> items;
    public float red;
    public float green;
    public float blue;

    public int level;
    public int prog_strength;
    public int prog_agility;
    public int prog_endurance;
    public int req_wins;
    public int req_strength;
    public int req_agility;
    public int req_endurance;
    public bool tutorial_shop;
    public bool tutorial_menu;
    public bool tutorial_training;
    public bool tutorial_battle; 
}
