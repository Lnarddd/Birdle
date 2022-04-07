using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class Agility_Controls : MonoBehaviour
{
    public float velocity = 1;
    bool dead = false;
    float timer = 0.5f;
    [SerializeField] AudioClip fly;
    [SerializeField] AudioClip hit;
    [SerializeField] AudioSource source;
    [SerializeField] Rigidbody2D rb;
    SpriteRenderer m_SpriteRenderer;
    Color m_NewColor;

    void Start() {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_NewColor = new UnityEngine.Color32((byte)(player_stats.red), (byte)(player_stats.green), (byte)(player_stats.blue), 255);
        m_SpriteRenderer.color = m_NewColor;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && dead==false){
            source.PlayOneShot(fly);
            rb.velocity = Vector2.up * velocity;
        }

        if(dead==true){
            timer -= 1 * Time.deltaTime;
        }

        if(timer < 0){
            death();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Obstacle"){
            dead = true;  
            source.PlayOneShot(hit);
        }
    }
    
    private void OnBecameInvisible() {
        if(Time.timeScale == 1){
            dead = true;
            source.PlayOneShot(hit);
        }
    }
    
    void death(){
        Destroy(gameObject);
        SceneManager.LoadScene("Agility_Minigame_Endscreen");
    }


}
