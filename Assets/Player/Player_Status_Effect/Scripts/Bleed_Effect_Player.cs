using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bleed_Effect_Player : MonoBehaviour
{
    [SerializeField] ParticleSystem ps;
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip bleed;
    GameObject Target;
    private float duration;
    private float dpt = 1.5f; //The damage hits every 1.5 seconds
    private int damage;

    void Start() {
        duration = 3 + (player_stats.endurance * 0.1f); //duration scales with endurance
        damage = 1 + (int)(player_stats.endurance * 0.05);
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
                    source.PlayOneShot(bleed);
                    Target = GameObject.FindWithTag("Player");
                    Player_AI TargetHit = Target.GetComponent<Player_AI>();
                    TargetHit.hurt(damage);
                    dpt = 1.5f;
                }

        }

        else{
            Destroy(gameObject);
        }
    }
}
