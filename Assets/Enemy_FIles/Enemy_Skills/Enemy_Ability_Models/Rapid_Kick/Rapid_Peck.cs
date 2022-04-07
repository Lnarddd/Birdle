using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rapid_Peck : MonoBehaviour
{
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;
    [SerializeField] int damage;
    int times;
    GameObject Target;

    private void Start() {
        times = Random.Range(1,4);
        switch (player_progress.level){
            case 1:
                damage *= 1;
                break;
            case 2:
                damage *= 2;
                break;
            case 3:
                damage *= 2;
                break;
            case 4:
                damage *= 3;
                break;
        }
    }

    private void Update() {
        if(times <= 0){
            Destroy(gameObject);
        }
    }

    public void hit(){
        if (times > 0){
            Target = GameObject.FindWithTag("Player");
            Player_AI TargetHit = Target.GetComponent<Player_AI>();
            TargetHit.hurt(damage);
            source.PlayOneShot(clip);
            times -= 1;
        }
    }
}
