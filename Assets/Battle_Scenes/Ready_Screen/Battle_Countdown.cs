using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battle_Countdown : MonoBehaviour
{
    float timer = 5;
    [SerializeField] Text TextCountdown;

    // Start is called before the first frame update
    void Start()
    {
        player_progress.player_ready = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        int timerint = (int)timer;
        timer -= 1 * Time.deltaTime;

        switch(timerint){
            case 4:
                TextCountdown.text = "3";
                break;
            case 3:
                TextCountdown.text = "2";
                break;
            case 2:
                TextCountdown.text = "1";
                break;
            case 1:
                TextCountdown.text = "FIGHT!";
                break;
            case 0:
                player_progress.player_ready = true;
                Destroy(gameObject);        
                break;
        }

    }
}
