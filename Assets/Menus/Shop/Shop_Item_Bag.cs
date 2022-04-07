using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Shop_Item_Bag : MonoBehaviour, IPointerEnterHandler
{
    Button button;
    AudioSource source;
    [SerializeField] int price;
    [SerializeField] Text dialogue;
    [SerializeField] string description;
    [SerializeField] string thanks;
    
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        source = GetComponent<AudioSource>();
    }

    private void Update() {
        if(player_stats.item_2_unlocked == true | price > player_stats.cash){
            button.interactable = false;
        }
        else{
            button.interactable = true;
        }
    }

    public void buy(){
        source.Play();
        player_stats.cash -= price;
        player_stats.item_2_unlocked = true;
        dialogue.text = thanks;
    }

    public void OnPointerEnter(PointerEventData eventData){
        dialogue.text = description;
    }    
}
