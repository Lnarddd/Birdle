using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Move_2 : MonoBehaviour
{
    public float speed;
    public float verticalspeed;
    public float timetomove;
    float timeleft;
    int direction = 1;

    void Start() {
        direction = Random.Range(-1,2);
        timeleft = timetomove;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        
        if (timeleft > 0){
            timeleft -= 1 * Time.deltaTime;
        }
        else{
            timeleft = timetomove;
            direction *= -1;
        }

        if (direction == 1){
            transform.position += Vector3.up * verticalspeed * Time.deltaTime;
        }
        else{
            transform.position += Vector3.down * verticalspeed * Time.deltaTime;
        }

        if (direction == 0){
            direction = Random.Range(-1,2);
        }
    }

    void OnBecameInvisible() {
        Destroy(gameObject);    
    }
}
