using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Help : MonoBehaviour
{
    [SerializeField] GameObject Window;

    // Start is called before the first frame update
    void Start()
    {
        if(player_progress.tutorial_shop == false){
            Window.SetActive(true);
            player_progress.tutorial_shop = true;
        }
    }

}
