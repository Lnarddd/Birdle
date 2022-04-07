using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Move_4 : MonoBehaviour
{
    public float verticalspeed;
    public float timetomove;
    float timeleft;
    int direction = -1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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

    }
}
