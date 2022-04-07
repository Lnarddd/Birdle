using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_stats : MonoBehaviour
{
    public static string bird_name = "Birdie";
    public static int cash = 9999;
    public static int speed = 99;
    public static int strength = 99;
    public static int endurance = 99;
    public static int wins;
    public static int loss;
    public static float red = 255;
    public static float green = 255;
    public static float blue = 255;
    
    public static List<string> items = new List<string>();

    public static bool item_2_unlocked = true;
    public static string item_1 = "Peck";
    public static string item_2 = "Flute";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

