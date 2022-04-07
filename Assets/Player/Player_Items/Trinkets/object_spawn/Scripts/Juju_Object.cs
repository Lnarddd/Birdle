using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juju_Object : MonoBehaviour
{
    [SerializeField] float heal;
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;
    GameObject Target;

    private void Update() {
        Destroy(GameObject.FindWithTag("debuff"));
    }

    public void healing(){
        Destroy(gameObject);
    }

    public void sound(){
        Target = GameObject.FindWithTag("Player");
        Player_AI TargetHit = Target.GetComponent<Player_AI>();
        TargetHit.healing(heal);
        TargetHit.stun(false);
        source.PlayOneShot(clip);
    }
}
