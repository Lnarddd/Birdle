using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Char_creator : MonoBehaviour
{
    private List<string> colors = new List<string>();
    string currentcolor;
    int currentnumber;
    int count;
    string textbox;
    public GameObject inputField;
    public Button button;
    
    // Start is called before the first frame update
    void Start()
    {
        colors.Add("white");
        colors.Add("red");
        colors.Add("blue");
        colors.Add("green");
        colors.Add("yellow");
        count = colors.Count;
    }

    // Update is called once per frame
    void Update()
    {
        if(textbox == ""){
            button.interactable = false;
        }
        else{
            button.interactable = true;
        }

        textbox = inputField.GetComponent<Text>().text;

        switch(currentcolor){
            case "red":
                player_stats.red = 255;
                player_stats.green = 0;
                player_stats.blue = 77;
                break;
            case "blue":
                player_stats.red = 41;
                player_stats.green = 173;
                player_stats.blue = 255;
                break;
            case "green":
                player_stats.red = 0;
                player_stats.green = 228;
                player_stats.blue = 54;
                break;
            case "yellow":
                player_stats.red = 255;
                player_stats.green = 236;
                player_stats.blue = 39;
                break;
            case "white":
                player_stats.red = 255;
                player_stats.green = 255;
                player_stats.blue = 255;
                break;
        }
    }

    public void next(){
        if(count-1 > currentnumber){
            currentnumber += 1;
            currentcolor = colors[currentnumber];
        }
    }

    public void prev(){
        if(currentnumber > 0){
            currentnumber -= 1;
            currentcolor = colors[currentnumber];
        }
    }

    public void enter(){
        player_stats.bird_name = textbox;
    }
}
