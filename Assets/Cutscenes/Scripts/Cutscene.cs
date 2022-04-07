using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
    [SerializeField] string text, text2, text3, text4, text5;
    [SerializeField] int lines;
    [SerializeField] Text chat;
    [SerializeField] AudioClip next;
    [SerializeField] AudioSource source;
    [SerializeField] bool ending;
    int currentline = 1;

    void Start()
    {
        chat.text = text;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && currentline < lines){
        currentline += 1;
        source.PlayOneShot(next);
           switch(currentline){
               case 1:
                chat.text = text;
                break;
               case 2:
                chat.text = text2;
                break;
               case 3:
                chat.text = text3;
                break;
               case 4:
                chat.text = text4;
                break;
               case 5:
                chat.text = text5;
                break;
           }
       }

        else if(Input.GetMouseButtonDown(0) && currentline == lines){
            if(ending == true){
                SceneManager.LoadScene("Congratulations");
            }
            else{
                SceneManager.LoadScene("Game_Menu");
            }
       }
    }
}