using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;

public class Boss_Scene : MonoBehaviour
{
    [SerializeField] Text subtext;

    // Start is called before the first frame update
    void Start()
    {
        switch(player_progress.level){
            case 1:
                subtext.text = "YOU ARE NOW THE ISLANDS's CHAMPION";
                break;
            case 2:
                subtext.text = "YOU ARE NOW THE OUTBACK's CHAMPION";
                break;
            case 3:
                subtext.text = "YOU ARE NOW THE SAVANNAH'S CHAMPION";
                break;
            case 4:
                subtext.text = "YOU ARE NOW THE MOUNTAIN'S CHAMPION";
                break;
            default:
                subtext.text = "PLEASE REPORT BUG!";
                break;
        }
    }

    public void next_level(){
        if(player_progress.level < 4){
            player_progress.level += 1;
            player_progress.req_wins += 10;
            player_stats.wins = 0;

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
        else{
            SceneManager.LoadScene("Cutscene_5");
        }
    }
}
