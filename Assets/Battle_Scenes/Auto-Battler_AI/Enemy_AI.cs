using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Enemy_AI : MonoBehaviour
{   
    GameObject Target;
    GameObject Enemy_Health;
    GameObject Enemy_Text;
    GameObject Healthbar;
    [SerializeField] Animator animator;
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip hit;
    [SerializeField] AudioClip death;
    [SerializeField] bool boss;

    //A.I. Choices and abilities
    [SerializeField] bool Ability_1_aggressive;
    [SerializeField] bool Ability_1_randomly;
    [SerializeField] bool Ability_1_low_health;
    [SerializeField] bool Ability_2_aggressive;
    [SerializeField] bool Ability_2_randomly;
    [SerializeField] bool Ability_2_low_health;
    [SerializeField] int Ability_1_Odds;
    [SerializeField] int Ability_2_Odds;
    [SerializeField] GameObject Ability_1;
    [SerializeField] float Ability_1_Cooldown;
    private float Ability_1_Cooldown_Left;
    [SerializeField] GameObject Ability_2;
    [SerializeField] float Ability_2_Cooldown;
    private float Ability_2_Cooldown_Left;
    private int low_health;
    private float randomtimer_1 = 2;
    private float randomtimer_2 = 2;

    //enemy stats 
    Text healthtext;
    Text nametag;
    [SerializeField] string Name;
    [SerializeField] int max_cash;
    [SerializeField] int min_cash;
    private int health;
    private int damage = 5;
    private int totalhealth = 100;
    private float currentTime = 0f;
    private float startingTime = 1.5f;
    private float attackspeed;
    public int strength;
    public float agility;
    public int endurance;
    private bool dead = false;
    private bool stunned = false;

    // add multiplier for items and shit in the future for now stay with base
    void Start()
    {
        if(player_stats.strength > strength){
            strength = strength + (int)(player_stats.strength * 0.1f);
        }
        if(player_stats.speed > agility){
            agility = agility + (int)(player_stats.speed * 0.1f); 
        }
        if(player_stats.endurance > endurance){
            endurance = endurance + (int)(player_stats.endurance * 0.1f); 
        }

        //This is for the name and health text and shit like that
        Enemy_Health = GameObject.FindWithTag("Enemy_Health");
        healthtext = Enemy_Health.GetComponent<Text>();
        Enemy_Text = GameObject.FindWithTag("Enemy_Text");
        nametag = Enemy_Text.GetComponent<Text>();
        nametag.text = Name;

        totalhealth += endurance * 20;
        damage += strength * 3;
        attackspeed = agility/100;
        startingTime -= attackspeed;
        currentTime = startingTime;
        health = totalhealth;
        healthtext.text = health.ToString() + "/" + totalhealth.ToString();

        //if this is higher than 0 this would trigger the ability AI, make sure you check one of the bools on the inspector :)
        low_health = (int)(totalhealth*0.30); 

        Healthbar = GameObject.FindWithTag("Enemy_Health_Bar");
    }

    // Update is called once per frame
    void Update()
    {
        Enemy_Health_Bar healthupdate = Healthbar.GetComponent<Enemy_Health_Bar>();
        healthupdate.Health_Bar(health,totalhealth);

        if(player_progress.player_ready == true && dead == false){
            currentTime -= 1 * Time.deltaTime;
            if (currentTime <= 0 ){
                attack();
                currentTime = startingTime;
            }

            if(currentTime < 0.04){
                if(stunned == false){
                    animator.SetBool("IsAttacking", true);
                }
            }

            //the abilities would only work if you set up a timer on it under skill cooldown.
            if(Ability_1_Cooldown > 0){
                if (Ability_1_Cooldown_Left > 0){
                    Ability_1_Cooldown_Left -= 1 * Time.deltaTime;
                }
                else{
                    ability1();
                }
            }
            if(Ability_2_Cooldown > 0){
                if (Ability_2_Cooldown_Left > 0){
                    Ability_2_Cooldown_Left -= 1 * Time.deltaTime;
                }
                else{
                    ability2();
                }
            }
        }

        if (this.animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && dead == true && this.animator.GetCurrentAnimatorStateInfo(0).IsName("Enemy_Dead")){
            if(boss == true){
                SceneManager.LoadScene("End_Screen_Win_Boss");
                Destroy(gameObject);
            }
            else{
                SceneManager.LoadScene("End_Screen_Win");
                Destroy(gameObject);
            }
        }
    }

    void ability1(){
    if(stunned == false){
            if (Ability_1_aggressive == true && Ability_1_Cooldown_Left <= 0) {
                Instantiate(Ability_1);
                Ability_1_Cooldown_Left = Ability_1_Cooldown;
            }
            if (Ability_1_low_health == true && Ability_1_Cooldown_Left <= 0) {
                if(health <= low_health){
                    Instantiate(Ability_1);
                    Ability_1_Cooldown_Left = Ability_1_Cooldown;
                }
            }
            if (Ability_1_randomly == true && Ability_1_Cooldown_Left <= 0) {
                randomtimer_1 -= 1 * Time.deltaTime;
                    if(randomtimer_1 <= 0){
                        int action_roll_1 = Random.Range(1,Ability_1_Odds);
                        randomtimer_1 = 2;
                            if (action_roll_1 == 1){
                                Instantiate(Ability_1);
                                Ability_1_Cooldown_Left = Ability_1_Cooldown;
                            }
                    }
            }
        }
    }

    void ability2(){
        if(stunned == false){
            if (Ability_2_aggressive == true && Ability_2_Cooldown_Left <= 0) {
                Instantiate(Ability_2);
                Ability_2_Cooldown_Left = Ability_2_Cooldown;
            }
            if (Ability_2_low_health == true && Ability_2_Cooldown_Left <= 0) {
                if(health <= low_health){
                    Instantiate(Ability_2);
                    Ability_2_Cooldown_Left = Ability_2_Cooldown;
                }
            }
            if (Ability_2_randomly == true && Ability_2_Cooldown_Left <= 0) {
                randomtimer_2 -= 1 * Time.deltaTime;
                    if(randomtimer_2 <= 0){
                        int action_roll_2 = Random.Range(1,Ability_2_Odds);
                        randomtimer_2 = 2;
                            if (action_roll_2 == 1){
                                Instantiate(Ability_2);
                                Ability_2_Cooldown_Left = Ability_2_Cooldown;
                            }
                    }
            }
        }
    }

    void attack()
    {
        if(stunned == false){
            Target = GameObject.FindWithTag("Player");
            Player_AI TargetHit = Target.GetComponent<Player_AI>();
            TargetHit.hurt(damage);
            animator.SetBool("IsAttacking", false);
            source.PlayOneShot(hit);
        }
    }

    public void hurt(int damagetaken)
    {
        health -= damagetaken;
        healthtext.text = health.ToString() + "/" + totalhealth.ToString();
        if(health <= 0 && dead==false){
            player_stats.wins += 1;
            player_progress.money_earned = Random.Range(min_cash,max_cash);
            player_stats.cash += player_progress.money_earned;
            animator.SetBool("IsDead", true);
            dead = true;
            source.PlayOneShot(death);
        }
    }

    public void healing(int heal)
    {   
        if(dead==false){
            health += heal;
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
