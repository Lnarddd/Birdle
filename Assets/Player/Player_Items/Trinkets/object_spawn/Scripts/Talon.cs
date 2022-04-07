using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talon : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;
    GameObject Target;
    Animator anim;
    bool playing = false;

    void Start()
    {
        anim = transform.GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1){
            Target = GameObject.FindWithTag("Enemy");
            Enemy_AI TargetHit = Target.GetComponent<Enemy_AI>();
            TargetHit.hurt(damage);
            Destroy(gameObject);
        }

        if (this.anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.8 && playing == false){
            playing = true;
            source.PlayOneShot(clip);
        }
    }
}
