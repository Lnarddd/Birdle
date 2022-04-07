using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grapple : MonoBehaviour
{
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;
    [SerializeField] int damage, stun_times;
    GameObject Target;

    private void Start() {
        Target = GameObject.FindWithTag("Player");
        Player_AI TargetHit = Target.GetComponent<Player_AI>();
        TargetHit.stun(true);
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
        Target = GameObject.FindWithTag("Player");
        Player_AI TargetHit = Target.GetComponent<Player_AI>();
        TargetHit.hurt(damage);
        source.PlayOneShot(clip);
    }

    public void stun(){
        if(stun_times > 0){
            Target = GameObject.FindWithTag("Player");
            Player_AI TargetHit = Target.GetComponent<Player_AI>();
            TargetHit.stun(true);
            stun_times -= 1;
        }

        else{
            Target = GameObject.FindWithTag("Player");
            Player_AI TargetHit = Target.GetComponent<Player_AI>();
            TargetHit.stun(false);
            Destroy(gameObject);
        }
    }
}
