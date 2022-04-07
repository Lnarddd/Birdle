using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salve_Object : MonoBehaviour
{
    [SerializeField] float heal;
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;
    GameObject Target;
    float Timer = 1;


    // Start is called before the first frame upd 
    void Start()
    {
        Target = GameObject.FindWithTag("Player");
        Player_AI TargetHit = Target.GetComponent<Player_AI>();
        TargetHit.healing(heal);
        source.PlayOneShot(clip);
    }

    void Update() {
        Timer -= 1 * Time.deltaTime;
        if(Timer < 0){
            Destroy(gameObject);
        }
    }
}
