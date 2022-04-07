using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Player_AI : MonoBehaviour
{
    GameObject Target;
    GameObject Healthbar;
    private int health;
    private int damage = 5;
    private int totalhealth = 100;
    private float currentTime = 0f;
    private float startingTime = 2f;
    private float attackspeed;
    private int strength = player_stats.strength;
    private float agility = player_stats.speed;
    private int endurance = player_stats.endurance;
    private bool dead = false;
    private bool stunned = false;
    [SerializeField] Text healthtext;
    [SerializeField] Text Name;
    [SerializeField] Animator animator;
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip hit;
    [SerializeField] AudioClip death;

    SpriteRenderer m_SpriteRenderer;
    Color m_NewColor;

    // Prepare code for some bullshit like buffs and shit
    void Start()
    {
        Name.text = player_stats.bird_name;
        totalhealth += endurance * 20;
        damage += strength * 3;
        attackspeed = agility/100;
        startingTime -= attackspeed;
        currentTime = startingTime;
        health = totalhealth;
        healthtext.text = health.ToString() + "/" + totalhealth.ToString();
    
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_NewColor = new UnityEngine.Color32((byte)(player_stats.red), (byte)(player_stats.green), (byte)(player_stats.blue), 255);
        m_SpriteRenderer.color = m_NewColor;

        Healthbar = GameObject.FindWithTag("Player_Health_Bar");
    }

    // Cock and balls this is the timer where you can set how fast you attack every second
    void Update(){
        Player_Health_Bar healthupdate = Healthbar.GetComponent<Player_Health_Bar>();
        healthupdate.Health_Bar(health,totalhealth);

        if(player_progress.player_ready == true && dead == false){
            currentTime -= 1 * Time.deltaTime;
            if (currentTime <= 0 ){
                attack();
                currentTime = startingTime;
            }

            if(currentTime < 0.04){
                animator.SetBool("IsAttacking", true);
            }
        }

        if (this.animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && dead == true){
            SceneManager.LoadScene("End_Screen_Loss");
            Destroy(gameObject);
        }
    }

    void attack(){
        if(stunned == false){
            Target = GameObject.FindWithTag("Enemy");
            Enemy_AI TargetHit = Target.GetComponent<Enemy_AI>();
            TargetHit.hurt(damage);
            animator.SetBool("IsAttacking", false);
            source.PlayOneShot(hit);
        }
    }

    public void hurt(int damagetaken){
        health -= damagetaken;
        healthtext.text = health.ToString() + "/" + totalhealth.ToString();
        if(health <= 0 && dead == false){
            player_stats.loss += 1;
            animator.SetBool("IsDead", true);
            dead = true;
            source.PlayOneShot(death);
        }
    }

    public void healing(float heal){   
        if(dead==false){
            float healed = totalhealth * heal;
            Debug.Log(healed);
            health += (int)healed;
            healthtext.text = health.ToString() + "/" + totalhealth.ToString();
            if(health > totalhealth){
                health = totalhealth;
                healthtext.text = health.ToString() + "/" + totalhealth.ToString();
            }
        }
    }

    public void stun(bool stun){
        stunned = stun;
    }

    public void poisoned(int damage){
        health -= damage;
        if(health <= 0){
            health = 1;
        }
    }

    public void damage_buff(int buff){
        damage += buff;
    }
}
