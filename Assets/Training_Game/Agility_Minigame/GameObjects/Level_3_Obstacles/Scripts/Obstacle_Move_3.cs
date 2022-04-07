using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Move_3 : MonoBehaviour
{
    public float speed;
    public float fallspeed;
  
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        transform.position += Vector3.down * fallspeed * Time.deltaTime;
    }

    private void OnBecameInvisible() {
        Destroy(gameObject);    
    }
}
