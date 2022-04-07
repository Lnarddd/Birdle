using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Natural_Healing : MonoBehaviour
{
    [SerializeField] int healing;
    [SerializeField] float timer;
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;
    [SerializeField] ParticleSystem system;
    GameObject Target;
    Animator anim;
    float time_delay = 1;

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;
        time_delay -= 1 * Time.deltaTime;

        if(time_delay < 0 && timer > 0){
            Target = GameObject.FindWithTag("Enemy");
            Enemy_AI TargetHit = Target.GetComponent<Enemy_AI>();
            TargetHit.healing(healing);
            source.PlayOneShot(clip);
            system.Play();
            time_delay = 1;
        }

        if(timer < 0){
            Destroy(gameObject);
        }
    }
}
