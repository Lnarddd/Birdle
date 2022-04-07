using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endurance_Controller : MonoBehaviour
{
    public float MovementSpeed;
    float MovementSpeedDefault;
    public float JumpForce;
    public Animator animator;
    SpriteRenderer m_SpriteRenderer;
    Color m_NewColor;
    [SerializeField] AudioClip jump;
    [SerializeField] AudioSource source;

    private Rigidbody2D rb;
  
    private void Start(){
        MovementSpeedDefault = MovementSpeed;
        rb = GetComponent<Rigidbody2D>();

        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_NewColor = new UnityEngine.Color32((byte)(player_stats.red), (byte)(player_stats.green), (byte)(player_stats.blue), 255);
        m_SpriteRenderer.color = m_NewColor;
    }

    private void Update() {

        var movement = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(movement));
        transform.position += new Vector3(movement,0,0) * Time.deltaTime * MovementSpeed;

        if(Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f ){
            source.PlayOneShot(jump);
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            MovementSpeed = MovementSpeed * 0.5f;

        }

        if(Mathf.Abs(rb.velocity.y) < 0.001f ){
            animator.SetBool("IsJumping", false);
            
        }
        else{
            animator.SetBool("IsJumping", true);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Obstacle"){
            SceneManager.LoadScene("Endurance_Minigame_Endscreen");
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Platform"){
            MovementSpeed = MovementSpeedDefault;
        }

        if (collision.gameObject.tag == "Slow"){
            MovementSpeed = MovementSpeed * 0.5f;
        }
    }

    private void OnBecameInvisible() {
        if(Time.timeScale == 1){
            death();
        }
    }

    void death(){
        Destroy(gameObject);
        SceneManager.LoadScene("Endurance_Minigame_Endscreen");
    }
}
