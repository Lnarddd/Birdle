using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peck_Attack : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;
    GameObject Target;
    Animator anim;
    int times;

    void Start()
    {
        times = Random.Range(1,7);
    }

    // Update is called once per frame
    void Update()
    {
        if(times < 0){
            Destroy(gameObject);
        }
    }

    public void Hit(){
        Target = GameObject.FindWithTag("Enemy");
        Enemy_AI TargetHit = Target.GetComponent<Enemy_AI>();
        TargetHit.hurt(damage);
        source.PlayOneShot(clip);
        times -= 1;
    }
}
