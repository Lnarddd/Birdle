using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost_Seed : MonoBehaviour
{
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;
    [SerializeField] int modifier;
    [SerializeField] float timer;
    GameObject Target;

    private void Start() {
        Target = GameObject.FindWithTag("Player");
        Player_AI TargetHit = Target.GetComponent<Player_AI>();
        TargetHit.damage_buff(modifier);
    }

    void Update() {
        timer -= 1 * Time.deltaTime;

        if(timer < 0){
            Target = GameObject.FindWithTag("Player");
            Player_AI TargetHit = Target.GetComponent<Player_AI>();
            TargetHit.damage_buff(-modifier);
            Destroy(gameObject);
        }
    }
}
