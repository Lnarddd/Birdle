using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Spawn : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject enemy2;
    [SerializeField] GameObject enemy3;
    [SerializeField] GameObject enemy4;
    [SerializeField] GameObject enemy5;
    [SerializeField] GameObject special_enemy; //Secret Enemy
    [SerializeField] int range;

    void Start()
    {
        Spawn();
    }

    void Spawn(){
        int spawnseed = Random.Range(1,range+1);
            switch(spawnseed){
                case 1:
                    int specialseed = Random.Range(1,500);
                        if(specialseed == 1){
                            Instantiate(special_enemy);
                        }
                        else{
                            Spawn();
                        }
                    break;
                case 2:
                    Instantiate(enemy);
                    break;
                case 3:
                    Instantiate(enemy2);
                    break;
                case 4:
                    Instantiate(enemy3);
                    break;
                case 5:
                    Instantiate(enemy4);
                    break;
                case 6:
                    Instantiate(enemy5);
                    break;
            }
    }
}