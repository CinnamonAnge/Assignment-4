using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI; 

public class ShopManager : MonoBehaviour
{

    public int[,] shopItems = new int[5, 5];
    public float coins;
    public TextMeshProUGUI CoinsText;
    [SerializeField] public AudioSource PurchaseConfirm;
    [SerializeField] public AudioSource PurchaseError;


    // Start is called before the first frame update
    void Start()
    {
        CoinsText.text = "Coins:" + coins.ToString();

        //Shop Item ID 
        shopItems[1,1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;

        //Prices
        shopItems[2, 1] = 10;
        shopItems[2, 2] = 20;
        shopItems[2, 3] = 30;
        shopItems[2, 4] = 40;

        //Quantity
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
        shopItems[3, 4] = 0;
    }

    public void Purchase()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;


        if(coins >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
            CoinsText.text = "Coins:" + coins.ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityText.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();

            //Audio for purchase
            AudioSource newSound = Instantiate(PurchaseConfirm, transform.position, Quaternion.identity);
            Destroy(newSound.gameObject, newSound.clip.length);


        } else if (coins < shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            //Current coins cannot purchase item
            CoinsText.text = "Coins: Not Enough!!";


            //Purchase Error sound 
            AudioSource newSound = Instantiate(PurchaseError, transform.position, Quaternion.identity);
            Destroy(newSound.gameObject, newSound.clip.length);
        }


    }
}
