using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seeds : MonoBehaviour
{
    Button startButton;
    [SerializeField] GameObject startButtonObject;
    [SerializeField] GameObject spawn;

    // Start is called before the first frame update
    void Start()
    {
        startButton = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 0){
            startButtonObject.SetActive(false);
        }
        else if(Time.timeScale == 1){
            startButtonObject.SetActive(true);
        }
    }

    public void onActivate(){
        Instantiate(spawn);
        player_stats.items.Remove("Seeds");
        startButton.interactable = false;

        if(player_stats.item_1 == "Seeds"){
            player_stats.item_1 = null;
        }
        else if(player_stats.item_2 == "Seeds"){
            player_stats.item_2 = null;
        }
    }
}
