using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health_Bar : MonoBehaviour
{
    private Image HealthBar;

    void Start()
    {
        HealthBar = GetComponent<Image>();
    }

    public void Health_Bar(int currenthealth, int maxhealth){
       float currenthealth_float = (float)currenthealth; 
       float maxhealth_float = (float)maxhealth;

       HealthBar.fillAmount = currenthealth_float / maxhealth_float;
    }
}
