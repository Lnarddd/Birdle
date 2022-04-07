using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleanse : MonoBehaviour
{
    [SerializeField] int heal;
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;
    GameObject Target;

    private void Update() {
        Destroy(GameObject.FindWithTag("debuff_enemy"));
    }

    public void healing(){
        Destroy(gameObject);
    }

    public void sound(){
        Target = GameObject.FindWithTag("Enemy");
        Enemy_AI TargetHit = Target.GetComponent<Enemy_AI>();
        TargetHit.healing(heal);
        TargetHit.stun(false);
        source.PlayOneShot(clip);
    }
}
