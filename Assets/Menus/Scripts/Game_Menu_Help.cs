using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Menu_Help : MonoBehaviour
{
    [SerializeField] GameObject Window;

    // Start is called before the first frame update
    void Start()
    {
        if(player_progress.tutorial_menu == false){
            Window.SetActive(true);
            player_progress.tutorial_menu = true;
        }
    }
}
