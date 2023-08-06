using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{


    public int ItemID;
    public TextMeshProUGUI PriceText;
    public TextMeshProUGUI QuantityText;
    public GameObject ShopManager;


    void Update()
    {
        PriceText.text = "Price: $" + ShopManager.GetComponent<ShopManager>().shopItems[2, ItemID].ToString();
        QuantityText.text = ShopManager.GetComponent<ShopManager>().shopItems[3, ItemID].ToString();
    }


}
    
