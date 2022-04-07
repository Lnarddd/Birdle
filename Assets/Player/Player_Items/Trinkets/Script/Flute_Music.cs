using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flute_Music : MonoBehaviour
{
    [SerializeField] float timer;
    GameObject Target;

    void Start() {
        Target = GameObject.FindWithTag("Enemy");
        Enemy_AI TargetHit = Target.GetComponent<Enemy_AI>();
        TargetHit.stun(true);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;    

        if(timer < 0){
            Target = GameObject.FindWithTag("Enemy");
            Enemy_AI TargetHit = Target.GetComponent<Enemy_AI>();
            TargetHit.stun(false);
            Destroy(gameObject);
        }
    }
}
