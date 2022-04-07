using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnPoint3 : MonoBehaviour
{
    float timetospawn = 1f;
    float timetospawnleft = 2f;
    float timetospeedup = 15f;
    float distancetraveled;
    float distancepersecond = 30f;
    bool reachmaxspeed = false;
    public GameObject tree;
    public GameObject vine;
    public GameObject bush;
    public GameObject giraffe;
    public GameObject wasp;
    public GameObject banana;
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
                timetospeedup = 15f;
                if(timetospawnleft > 1){
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
                Instantiate(tree, new Vector3( 10, Random.Range(-8,-5), 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(vine);
                break;
            case 3:
                Instantiate(bush, new Vector3( 12, 0, 0), Quaternion.identity);
                break;
            case 4:
                Instantiate(giraffe, new Vector3( 12, Random.Range(-4,-2), 0), Quaternion.identity);
                break;
            case 5:
                Instantiate(wasp, new Vector3( 12, Random.Range(-2, 3), 0), Quaternion.identity);
                break;
            case 6:
                Instantiate(banana, new Vector3( Random.Range(2, 5), 5, 0), Quaternion.identity);
                break;
            case 7:
                Instantiate(coins, new Vector3( 10, Random.Range(-1,3), 0), Quaternion.identity);
                break;
        }

    }
}