using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    AudioSource source;
    int cash = 1;

    private void Start() {
        source = GetComponent<AudioSource>();

        switch (player_progress.level){
            case 1:
                cash *= 1;
                break;
            case 2:
                cash *= 3;
                break;
            case 3:
                cash *= 5;
                break;
            case 4:
                cash *= 10;
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
         if (collision.gameObject.tag == "Player"){
            player_stats.cash += cash;
            source.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player"){
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible() {
        Destroy(gameObject);
    }
}
