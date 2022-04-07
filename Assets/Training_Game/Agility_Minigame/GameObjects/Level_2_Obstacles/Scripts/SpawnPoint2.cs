using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnPoint2 : MonoBehaviour
{
    float timetospawn = 1f;
    float timetospawnleft = 2f;
    float timetospeedup = 10f;
    float distancetraveled;
    float distancepersecond = 50f;
    bool reachmaxspeed = false;
    public GameObject drone;
    public GameObject glider;
    public GameObject plateau;
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
        int spawnseed = Random.Range(1,5);

        switch(spawnseed){
            case 1:
                Instantiate(drone, new Vector3( 10, 0, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(glider, new Vector3( 10, Random.Range(-2,5), 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(plateau, new Vector3( 12, Random.Range(-3,0), 0), Quaternion.identity);
                break;
            case 4:
                Instantiate(coins, new Vector3( 10, Random.Range(-1,3), 0), Quaternion.identity);
                break;
        }

    }
}
