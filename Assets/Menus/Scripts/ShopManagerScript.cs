using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class ShopManagerScript : MonoBehaviour
{
    public int Cash = player_stats.cash; //not sure if linked properly to the correct currency
    public TMP_Text CashUI;
    public ShopItemObject[] ShopItemObjects;
    public ShopTemplate[] ShopItemPanels;
    public GameObject[] ShopItemPanelsGO;
    public Button[] buybtn;

    void Start()
    {   //just to hide panels that are not in use
        for (int i = 0; i < ShopItemPanelsGO.Length; i++)
            ShopItemPanelsGO[i].SetActive(true);
        CashUI.text = "Cash: " + player_stats.cash.ToString();
        LoadItemPanels();
        Checkb4Buy();
        
    }

   //use to load the panels in game
    public void LoadItemPanels()
    {
        for (int i = 0; i < ShopItemObjects.Length; i++)
        {
            ShopItemPanels[i].titletxt.text = ShopItemObjects[i].Title;
            ShopItemPanels[i].Price_Costtxt.text = "Cash: " + ShopItemObjects[i].Price_Cost.ToString();
        }
    }

    //checks for the Cash and price of the items
    public void Checkb4Buy()
    {
        for (int i = 0; i < ShopItemObjects.Length; i++)
        if (player_stats.cash >= ShopItemObjects[i].Price_Cost)
            buybtn[i].interactable = true;
        else
            buybtn[i].interactable = false;
    }

    //buy button
    public void BuyItembtn(int btnNo)
    {
        if (player_stats.cash >= ShopItemObjects[btnNo].Price_Cost)
        {
            player_stats.cash = player_stats.cash - ShopItemObjects[btnNo].Price_Cost;
            CashUI.text = "Cash: " + player_stats.cash.ToString();
            Checkb4Buy();
            //buy item code
        }
    }

    
}
