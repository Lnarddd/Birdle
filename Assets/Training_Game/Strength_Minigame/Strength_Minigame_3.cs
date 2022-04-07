using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strength_Minigame_3 : MonoBehaviour
{
    public GameObject target; 
    public GameObject Not_target; 
    public AudioSource source;
    public AudioClip hit_sound;
    public AudioClip miss_sound;
    public int spawntargets;
    public int lastspawned;
    public int itemtoremove;
    List<int> OccupiedSpaces = new List<int>();

    void Start() {
        player_progress.score_strength = 0;
        Time.timeScale = 0f;
    }

    void Update() {
        if(Time.timeScale == 1){
            if(spawntargets>0){
                int spawnseed = Random.Range(1,10);
                if(spawnseed < 7){
                    spawnTargets();
                }
                else{
                    spawnEnemy();
                }
            }
        }
    }

    public void hit(){
        OccupiedSpaces.Remove(itemtoremove);
        source.PlayOneShot(hit_sound);
    }

    public void hitMiss(){
        OccupiedSpaces.Remove(itemtoremove);
    }

    public void wrong(){
        OccupiedSpaces.Remove(itemtoremove);
        source.PlayOneShot(miss_sound);
    }

    public void wrongMiss(){
        OccupiedSpaces.Remove(itemtoremove);
    }

    void spawnTargets(){
        int spawn = Random.Range(1, 16);
        if(OccupiedSpaces.Contains(spawn)){
            spawnTargets();
        }
        else{
            spawntargets-= 1;
            switch(spawn){
            case 1:
                Instantiate(target, new Vector3(-3,0,0),Quaternion.identity);
                OccupiedSpaces.Add(1);
                lastspawned = spawn;
                break;
            case 2:
                Instantiate(target, new Vector3(0,0,0),Quaternion.identity);
                OccupiedSpaces.Add(2);
                lastspawned = spawn;
                break;
            case 3:
                Instantiate(target, new Vector3(3,0,0),Quaternion.identity);
                OccupiedSpaces.Add(3);
                lastspawned = spawn;
                break;
            case 4:
                Instantiate(target, new Vector3(-3,3,0),Quaternion.identity);
                OccupiedSpaces.Add(4);
                lastspawned = spawn;
                break;
            case 5:
                Instantiate(target, new Vector3(0,3,0),Quaternion.identity);
                OccupiedSpaces.Add(5);
                lastspawned = spawn;
                break;
            case 6:
                Instantiate(target, new Vector3(3,3,0),Quaternion.identity);
                OccupiedSpaces.Add(6);
                lastspawned = spawn;
                break;
            case 7:
                Instantiate(target, new Vector3(-3,-3,0),Quaternion.identity);
                OccupiedSpaces.Add(7);
                lastspawned = spawn;
                break;
            case 8:
                Instantiate(target, new Vector3(0,-3,0),Quaternion.identity);
                OccupiedSpaces.Add(8);
                lastspawned = spawn;
                break;
            case 9:
                Instantiate(target, new Vector3(3,-3,0),Quaternion.identity);
                OccupiedSpaces.Add(9);
                lastspawned = spawn;
                break;
            case 10:
                Instantiate(target, new Vector3(6,-3,0),Quaternion.identity);
                OccupiedSpaces.Add(10);
                lastspawned = spawn;
                break;
            case 11:
                Instantiate(target, new Vector3(-6,-3,0),Quaternion.identity);
                OccupiedSpaces.Add(11);
                lastspawned = spawn;
                break;
            case 12:
                Instantiate(target, new Vector3(6,0,0),Quaternion.identity);
                OccupiedSpaces.Add(12);
                lastspawned = spawn;
                break;
            case 13:
                Instantiate(target, new Vector3(-6,0,0),Quaternion.identity);
                OccupiedSpaces.Add(13);
                lastspawned = spawn;
                break;
            case 14:
                Instantiate(target, new Vector3(6,3,0),Quaternion.identity);
                OccupiedSpaces.Add(14);
                lastspawned = spawn;
                break;
            case 15:
                Instantiate(target, new Vector3(-6,3,0),Quaternion.identity);
                OccupiedSpaces.Add(15);
                lastspawned = spawn;
                break;
            }
        }
    }

    void spawnEnemy(){
        int spawn = Random.Range(1, 16);
        if(OccupiedSpaces.Contains(spawn)){
            spawnEnemy();
        }
        else{
            spawntargets-= 1;
            switch(spawn){
            case 1:
                Instantiate(Not_target, new Vector3(-3,0,0),Quaternion.identity);
                OccupiedSpaces.Add(1);
                lastspawned = spawn;
                break;
            case 2:
                Instantiate(Not_target, new Vector3(0,0,0),Quaternion.identity);
                OccupiedSpaces.Add(2);
                lastspawned = spawn;
                break;
            case 3:
                Instantiate(Not_target, new Vector3(3,0,0),Quaternion.identity);
                OccupiedSpaces.Add(3);
                lastspawned = spawn;
                break;
            case 4:
                Instantiate(Not_target, new Vector3(-3,3,0),Quaternion.identity);
                OccupiedSpaces.Add(4);
                lastspawned = spawn;
                break;
            case 5:
                Instantiate(Not_target, new Vector3(0,3,0),Quaternion.identity);
                OccupiedSpaces.Add(5);
                lastspawned = spawn;
                break;
            case 6:
                Instantiate(Not_target, new Vector3(3,3,0),Quaternion.identity);
                OccupiedSpaces.Add(6);
                lastspawned = spawn;
                break;
            case 7:
                Instantiate(Not_target, new Vector3(-3,-3,0),Quaternion.identity);
                OccupiedSpaces.Add(7);
                lastspawned = spawn;
                break;
            case 8:
                Instantiate(Not_target, new Vector3(0,-3,0),Quaternion.identity);
                OccupiedSpaces.Add(8);
                lastspawned = spawn;
                break;
            case 9:
                Instantiate(Not_target, new Vector3(3,-3,0),Quaternion.identity);
                OccupiedSpaces.Add(9);
                lastspawned = spawn;
                break;
            case 10:
                Instantiate(Not_target, new Vector3(6,-3,0),Quaternion.identity);
                OccupiedSpaces.Add(10);
                lastspawned = spawn;
                break;
            case 11:
                Instantiate(Not_target, new Vector3(-6,-3,0),Quaternion.identity);
                OccupiedSpaces.Add(11);
                lastspawned = spawn;
                break;
            case 12:
                Instantiate(Not_target, new Vector3(6,0,0),Quaternion.identity);
                OccupiedSpaces.Add(12);
                lastspawned = spawn;
                break;
            case 13:
                Instantiate(Not_target, new Vector3(-6,0,0),Quaternion.identity);
                OccupiedSpaces.Add(13);
                lastspawned = spawn;
                break;
            case 14:
                Instantiate(Not_target, new Vector3(6,3,0),Quaternion.identity);
                OccupiedSpaces.Add(14);
                lastspawned = spawn;
                break;
            case 15:
                Instantiate(Not_target, new Vector3(-6,3,0),Quaternion.identity);
                OccupiedSpaces.Add(15);
                lastspawned = spawn;
                break;
            }
        }
    }
}
