using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnPoint4 : MonoBehaviour
{
    float timetospawn = 0.63f;
    float timetospawnleft = 0.63f;
    float distancetraveled;
    float distancepersecond = 25f;
    public GameObject cave1;
    public GameObject cave2;
    public GameObject cave3;
    public GameObject cave4;
    public GameObject cave5;
    public GameObject cave6;
    public GameObject cave7;
    public GameObject cave8;
    public GameObject cave9;
    public GameObject cave10;
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

        if(timetospawn > 0){
            timetospawn -= 1 * Time.deltaTime;
        }
        else{
            spawn();
            timetospawn = timetospawnleft;
        }
    }

    void spawn(){
        int spawnseed = Random.Range(1,11);

        switch(spawnseed){
            case 1:
                Instantiate(cave1, new Vector3( 20, 0, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(cave2, new Vector3( 20, 0, 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(cave3, new Vector3( 20, 0, 0), Quaternion.identity);
                break;
            case 4:
                Instantiate(cave4, new Vector3( 20, 0, 0), Quaternion.identity);
                break;
            case 5:
                Instantiate(cave5, new Vector3( 20, 0, 0), Quaternion.identity);
                break;
            case 6:
                Instantiate(cave6, new Vector3( 20, 0, 0), Quaternion.identity);
                break;
            case 7:
                Instantiate(cave7, new Vector3( 20, 0, 0), Quaternion.identity);
                break;
            case 8:
                Instantiate(cave8, new Vector3( 20, 0, 0), Quaternion.identity);
                break;
            case 9:
                Instantiate(cave9, new Vector3( 20, 0, 0), Quaternion.identity);
                break;
            case 10:
                Instantiate(cave10, new Vector3( 20, 0, 0), Quaternion.identity);
                break;
        }

    }
}
