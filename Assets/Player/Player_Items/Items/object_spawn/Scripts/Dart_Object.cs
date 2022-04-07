using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dart_Object : MonoBehaviour
{
    [SerializeField] GameObject poison;
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;
    [SerializeField] int damage;
    GameObject Target;
    Animator anim;
    bool playing = false;
    
    // Start is called before the first frame update hehe tite 8=====D
    void Start()
    {
        anim = transform.GetComponent<Animator> ();
    }

    void Update() {
        if (this.anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1){
            Target = GameObject.FindWithTag("Enemy");
            Enemy_AI TargetHit = Target.GetComponent<Enemy_AI>();
            TargetHit.hurt(damage);
            Instantiate(poison);
            Destroy(gameObject);
        }

        if (this.anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.8 && playing == false){
            playing = true;
            source.PlayOneShot(clip);
        }
    }
}
