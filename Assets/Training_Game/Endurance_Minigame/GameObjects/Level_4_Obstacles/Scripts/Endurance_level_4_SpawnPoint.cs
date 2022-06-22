using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Endurance_level_4_SpawnPoint : MonoBehaviour
{
    [SerializeField] float timetospawn;
    float timetospawnleft;
    [SerializeField] float timetospeedup;
    float timetospeedupleft;
    float distancetraveled;
    [SerializeField] float distancepersecond;
    bool reachmaxspeed = false;
    public GameObject obs2;
    public GameObject obs3;
    public GameObject obs4;
    public GameObject obs5;
    public GameObject obs6;
    public GameObject obs7;
    public GameObject coins;
    [SerializeField] Text countdownText;

    public void StartGame()
    {
        Time.timeScale = 1f;
    }

    void Start()
    {

        timetospawnleft = timetospawn;
        timetospeedupleft = timetospeedup;
        Time.timeScale = 0f;

    }

    // Update is called once per frame
    void Update()
    {

        distancetraveled += distancepersecond * Time.deltaTime;
        player_progress.score_endurance = distancetraveled;
        countdownText.text = distancetraveled.ToString("00m");

        if(reachmaxspeed == false ){
            if (timetospeedupleft > 0){
                timetospeedupleft -= 1 * Time.deltaTime;
            }
            else{
                timetospeedupleft = timetospeedup;
                if(timetospawnleft > 1.5){
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
        int spawnseed = Random.Range(1,8);

        switch(spawnseed){
            case 1:
                Instantiate(obs2);
                break;
            case 2:
                Instantiate(obs3);
                break;
            case 3:
                Instantiate(obs4);
                break;
            case 4:
                Instantiate(obs5);
                break;
            case 5:
                Instantiate(obs6, new Vector3( 10, Random.Range(0, 1), 0), Quaternion.identity);
                break;
            case 6:
                Instantiate(obs7, new Vector3( Random.Range(-3, 4), 10, 0), Quaternion.identity);
                break;
            case 7:
                Instantiate(coins, new Vector3( 10, Random.Range(-1,1), 0), Quaternion.identity);
                break;
        }

    }
}
