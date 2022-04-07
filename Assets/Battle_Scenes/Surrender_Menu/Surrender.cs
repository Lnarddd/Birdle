using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Surrender : MonoBehaviour
{
    [SerializeField] GameObject SurrenderMenu;
    [SerializeField] GameObject SurrenderButton;
    
    public void surrender(){
        SurrenderMenu.SetActive(true);
        SurrenderButton.SetActive(false);
        Time.timeScale = 0;
    }

    public void resume(){
        SurrenderMenu.SetActive(false);
        SurrenderButton.SetActive(true);
        Time.timeScale = 1;
    }
}
