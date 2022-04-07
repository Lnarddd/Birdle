using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Talisma_Talon : MonoBehaviour
{
    Button startButton;
    [SerializeField] GameObject startButtonObject;
    float currentcooldown;
    [SerializeField] float cooldown;
    GameObject Target;
    [SerializeField] GameObject spawn;
    [SerializeField] Text cooldowntext;

    // Start is called before the first frame update
    void Start()
    {
        startButton = GetComponent<Button>();
    }

    void Update() {

        if(currentcooldown > 0){
            currentcooldown -= 1 * Time.deltaTime;
            cooldowntext.text = currentcooldown.ToString("0");
        }

        else{
            startButton.interactable = true; 
            cooldowntext.text = currentcooldown.ToString(" ");
        }

        if(Time.timeScale == 0){
            startButtonObject.SetActive(false);
        }
        else if(Time.timeScale == 1){
            startButtonObject.SetActive(true);
        }
         
    }

    public void onActivate(){
        Instantiate(spawn);
        startButton.interactable = false;
        currentcooldown = cooldown;
    }
}
