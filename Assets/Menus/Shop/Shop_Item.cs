using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Shop_Item : MonoBehaviour, IPointerEnterHandler
{
    Button button;
    AudioSource source;
    [SerializeField] int price;
    [SerializeField] string Item_Name;
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
        if(player_stats.items.Contains(Item_Name) | price > player_stats.cash){
            button.interactable = false;
        }
        else{
            button.interactable = true;
        }
    }

    public void buy(){
        source.Play();
        player_stats.cash -= price;
        player_stats.items.Add(Item_Name);
        dialogue.text = thanks;
    }

    public void OnPointerEnter(PointerEventData eventData){
        dialogue.text = description;
    }    
}
