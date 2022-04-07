using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="ShopMenu", menuName = "Script Objects/New Shop Item", order =1)]
public class ShopItemObject : ScriptableObject
{
    public string Title;
    public int Price_Cost;
    //public string Description;
}
