using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone_Throw_Object : MonoBehaviour
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
    }

    void Update() {
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
