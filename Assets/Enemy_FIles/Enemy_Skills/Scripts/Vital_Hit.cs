using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vital_Hit : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;
    GameObject Target;
    Animator anim;
    bool playing = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = transform.GetComponent<Animator> ();
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

    void Update() {
        if (this.anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1){
            damage = Random.Range(damage,damage*2);
            Target = GameObject.FindWithTag("Player");
            Player_AI TargetHit = Target.GetComponent<Player_AI>();
            TargetHit.hurt(damage);
            Destroy(gameObject);
        }

        if (this.anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.8 && playing == false){
            playing = true;
            source.PlayOneShot(clip);
        }
    }

}
