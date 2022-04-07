using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Shope_Item_Power_Seed : MonoBehaviour, IPointerEnterHandler
{
    Button button;
    AudioSource source;
    [SerializeField] int price;
    [SerializeField] Text dialogue;
    [SerializeField] string description;
    [SerializeField] string thanks;
    int exp;
    int randomstat;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        source = GetComponent<AudioSource>();
    }

    private void Update() {
        if(price > player_stats.cash){
            button.interactable = false;
        }
        else{
            button.interactable = true;
        }
    }

    public void buy(){
        source.Play();
        randomstat = Random.Range(1,4);

        switch(randomstat){
            case 1:
                exp = player_progress.req_strength - player_progress.prog_strength;
                player_progress.LevelStrength(exp);
                Debug.Log("Str: " + player_stats.strength);
                break;
            case 2:
                exp = player_progress.req_endurance - player_progress.prog_endurance;
                player_progress.LevelEndurance(exp);
                Debug.Log("End: " + player_stats.endurance);
                break;
            case 3:
                exp = player_progress.req_agility - player_progress.prog_agility;
                player_progress.LevelAgility(exp);
                Debug.Log("Agi: " + player_stats.speed);
                break;
        }

        player_stats.cash -= price;
        dialogue.text = thanks;
    }

    public void OnPointerEnter(PointerEventData eventData){
        dialogue.text = description;
    } 
}
