using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeds_Object : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] int multiplier;
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;
    GameObject Target;
    Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = transform.GetComponent<Animator> ();
    }

    public void Hit(){
        Target = GameObject.FindWithTag("Enemy");
        Enemy_AI TargetHit = Target.GetComponent<Enemy_AI>();
        damage = damage * Random.Range(1,multiplier);
        TargetHit.hurt(damage);
        source.PlayOneShot(clip);
    }

    public void onEnd(){
        Destroy(gameObject);
    }
}
