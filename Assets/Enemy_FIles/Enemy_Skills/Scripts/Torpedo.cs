using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torpedo : MonoBehaviour
{
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;
    [SerializeField] AudioClip clip2;
    [SerializeField] int damage, self_damage;
    GameObject Target;

    private void Start() {
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
    public void hit(){
        int hit_roll = Random.Range(1,7);

        if(hit_roll == 1){
            Target = GameObject.FindWithTag("Player");
            Player_AI TargetHit = Target.GetComponent<Player_AI>();
            TargetHit.hurt(damage);
            source.PlayOneShot(clip);
        }
        else{
            source.PlayOneShot(clip2);
        }
    }

    public void self(){
        Target = GameObject.FindWithTag("Player");
        Enemy_AI TargetHit = Target.GetComponent<Enemy_AI>();
        Destroy(gameObject);
    }
}
