using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strength_Minigame_1 : MonoBehaviour
{
    public GameObject target; /*This is the target that would be instantiated please refer to strength minigame/gameobject */
    public GameObject Not_target; /*This is the not_target that would be instantiated please refer to strength minigame/gameobject*/
    public AudioSource Hit;
    public AudioSource Wrong;
    public int difficulty = 1; /*This is set on 1 as default the levels could be 1 or 2*/
    public int spawntargets;
    private int lastspawned = 0;
    
    void Start() {
        player_progress.score_strength = 0;
        Time.timeScale = 0f;
    }

    /*this checks every delta time for when the target is now available for release*/
    void Update() {
        if(Time.timeScale == 1){
            for(int i = spawntargets;i > 0; i--){
                spawntargets -= 1;
                spawnTargets();
            }
        }
    }

    /*This is some sound shit that triggers hehe*/
    public void PlayHit(){
        Destroy(GameObject.Find("Not_Target(Clone)"));
        Hit.Play();
    }
    public void PlayWrong(){
        Destroy(GameObject.Find("Target(Clone)"));
        Wrong.Play();
    }

    /*This is the default spawn for the minigame, need to improve on the spawning thing and try to research in creating sectors*/
    void spawnTargets(){
        int spawn = Random.Range(1, 10);
        if(spawn == lastspawned){
            spawnTargets();
        }
        else{
            switch(spawn){
            case 1:
                Instantiate(target, new Vector3(-3,0,0),Quaternion.identity);
                lastspawned = spawn;
                spawnEnemy();
                break;
            case 2:
                Instantiate(target, new Vector3(0,0,0),Quaternion.identity);
                lastspawned = spawn;
                spawnEnemy();
                break;
            case 3:
                Instantiate(target, new Vector3(3,0,0),Quaternion.identity);
                lastspawned = spawn;
                spawnEnemy();
                break;
            case 4:
                Instantiate(target, new Vector3(-3,3,0),Quaternion.identity);
                lastspawned = spawn;
                spawnEnemy();
                break;
            case 5:
                Instantiate(target, new Vector3(0,3,0),Quaternion.identity);
                lastspawned = spawn;
                spawnEnemy();
                break;
            case 6:
                Instantiate(target, new Vector3(3,3,0),Quaternion.identity);
                lastspawned = spawn;
                spawnEnemy();
                break;
            case 7:
                Instantiate(target, new Vector3(-3,-3,0),Quaternion.identity);
                lastspawned = spawn;
                spawnEnemy();
                break;
            case 8:
                Instantiate(target, new Vector3(0,-3,0),Quaternion.identity);
                lastspawned = spawn;
                spawnEnemy();
                break;
            case 9:
                Instantiate(target, new Vector3(3,-3,0),Quaternion.identity);
                lastspawned = spawn;
                spawnEnemy();
                break;
            }
        }
    }
    /*This only triggers when the difficulty is set to 2 if not it would be ignored*/
    void spawnEnemy(){
        if (difficulty == 2){
            int spawn = Random.Range(1,10);
            if(spawn == lastspawned){
            spawnEnemy();
            }
            else{
                switch(spawn){
                case 1:
                    Instantiate(Not_target, new Vector3(-3,0,0),Quaternion.identity);
                    break;
                case 2:
                    Instantiate(Not_target, new Vector3(0,0,0),Quaternion.identity);
                    break;
                case 3:
                    Instantiate(Not_target, new Vector3(3,0,0),Quaternion.identity);
                    break;
                case 4:
                    Instantiate(Not_target, new Vector3(-3,3,0),Quaternion.identity);
                    break;
                case 5:
                    Instantiate(Not_target, new Vector3(0,3,0),Quaternion.identity);
                    break;
                case 6:
                    Instantiate(Not_target, new Vector3(3,3,0),Quaternion.identity);
                    break;
                case 7:
                    Instantiate(Not_target, new Vector3(-3,-3,0),Quaternion.identity);
                    break;
                case 8:
                    Instantiate(Not_target, new Vector3(0,-3,0),Quaternion.identity);
                    break;
                case 9:
                    Instantiate(Not_target, new Vector3(3,-3,0),Quaternion.identity);
                    break;
                }
            }
        }
    }
}


