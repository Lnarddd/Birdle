using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Item_Selector : MonoBehaviour
{
    int current = -1;
    int current2 = -1;
    int count;
    [SerializeField] Text item_name;
    [SerializeField] Text item2_name;
    [SerializeField] Text Name;
    [SerializeField] Text Agility;
    [SerializeField] Text Strength;
    [SerializeField] Text Endurance;
    [SerializeField] GameObject Item_2_visible;

    void Start() {
        count = player_stats.items.Count;
        item_name.text = player_stats.item_1;
        item2_name.text = player_stats.item_2;

        Name.text = player_stats.bird_name;
        Agility.text = player_stats.speed.ToString("00");
        Strength.text = player_stats.strength.ToString("00");
        Endurance.text = player_stats.endurance.ToString("00");

        if(player_stats.item_2_unlocked == false){
            Item_2_visible.SetActive(false);
        }
        
        if(count <= 0){
            player_stats.item_1 = "items";
        }
    }
   
    public void item_1_next(){
        if(count-1 > current){
            current += 1;
            item_name.text = player_stats.items[current];
            player_stats.item_1 = player_stats.items[current];
        }
    }

    public void item_1_prev(){
        if(current > 0){
            current -= 1;
            item_name.text = player_stats.items[current];
            player_stats.item_1 = player_stats.items[current];
        }
    }

    public void item_2_next(){
        if(count-1 > current2){
            current2 += 1;
            item2_name.text = player_stats.items[current2];
            player_stats.item_2 = player_stats.items[current2];
        }
    }

    public void item_2_prev(){
        if(current2 > 0){
            current2 -= 1;
            item2_name.text = player_stats.items[current2];
            player_stats.item_2 = player_stats.items[current2];
        }
    }

    public void back(){
        SceneManager.LoadScene("Game_menu");
    }

    public void start(){
        if(player_stats.item_1 == player_stats.item_2 && player_stats.item_1 != null && player_stats.item_2 != null){
            Debug.Log("Error can't equip the same item");
        }
        else{
            switch(player_progress.level){
                case 1:
                    SceneManager.LoadScene("Battle_Scene_1");
                    break;
                case 2:
                    SceneManager.LoadScene("Battle_Scene_2");
                    break;
                case 3:
                    SceneManager.LoadScene("Battle_Scene_3");
                    break;
                case 4:
                    SceneManager.LoadScene("Battle_Scene_4");
                    break;
                case 5:
                    SceneManager.LoadScene("Battle_Scene_5");
                    break;
            }
        }
    }
}
