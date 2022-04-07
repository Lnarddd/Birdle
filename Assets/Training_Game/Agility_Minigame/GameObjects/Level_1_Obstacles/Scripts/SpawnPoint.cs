using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnPoint : MonoBehaviour
{
    float timetospawn = 1f;
    float timetospawnleft = 2f;
    float timetospeedup = 10f;
    float distancetraveled;
    float distancepersecond = 35f;
    bool reachmaxspeed = false;
    public GameObject kite;
    public GameObject tower;
    public GameObject coins;
    [SerializeField] Text countdownText;

    public void StartGame()
    {
        Time.timeScale = 1f;
    }

    void Start() {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        distancetraveled += distancepersecond * Time.deltaTime;
        player_progress.score_agility = distancetraveled;
        countdownText.text = distancetraveled.ToString("00m");

        if(reachmaxspeed == false ){
            if (timetospeedup > 0){
                timetospeedup -= 1 * Time.deltaTime;
            }
            else{
                timetospeedup = 10f;
                if(timetospawnleft > 0.5){
                    timetospawnleft -= 0.5f;
                }
                else{
                    reachmaxspeed = true;
                }
            }
        }

        if(timetospawn > 0){
            timetospawn -= 1 * Time.deltaTime;
        }
        else{
            spawn();
            timetospawn = timetospawnleft;
        }
    }

    void spawn(){
        int spawnseed = Random.Range(1,4);

        switch(spawnseed){
            case 1:
                Instantiate(kite, new Vector3( 10, Random.Range(2,6), 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(tower, new Vector3( 10, Random.Range(-8,-5), 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(coins, new Vector3( 10, Random.Range(2,4), 0), Quaternion.identity);
                break;
        }

    }
}
