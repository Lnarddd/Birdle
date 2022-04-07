using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison_Effect_Player : MonoBehaviour
{
    [SerializeField] ParticleSystem ps;
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip poison;
    GameObject Target;
    private float duration;
    private float dpt = 2; //The damage hits every 1.5 seconds
    private int damage;

    void Start() {
        duration = 10 + (player_stats.endurance * 0.1f); //duration scales with endurance
        damage = 5 + (int)(player_stats.endurance * 0.05);
    }
    
    // Update is called once per frame
    void Update()
    {
        if(duration > 0){  
            duration -= 1 * Time.deltaTime; 

                if(dpt > 0){
                dpt -= 1 * Time.deltaTime; 
                }
                else{
                    ps.Play();
                    source.PlayOneShot(poison);
                    Target = GameObject.FindWithTag("Player");
                    Player_AI TargetHit = Target.GetComponent<Player_AI>();
                    TargetHit.hurt(damage);
                    dpt = 2;
                }

        }

        else{
            Destroy(gameObject);
        }
    }
}
