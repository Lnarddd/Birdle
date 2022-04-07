using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power_Beam : MonoBehaviour
{
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;
    [SerializeField] int damage;
    GameObject Target;

    void Start(){
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
        source.PlayOneShot(clip);
        Target = GameObject.FindWithTag("Player");
        Player_AI TargetHit = Target.GetComponent<Player_AI>();
        TargetHit.hurt(damage);
    }

    public void killself(){
        Destroy(gameObject);
    }
}
