using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avoid_Collision_Minigame : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Obstacle"){
            Physics2D.IgnoreCollision(collision.collider, collision.otherCollider);
        }
    }
}
