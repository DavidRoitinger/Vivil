using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Costs : MonoBehaviour
{
    
    public TMP_Text uICost;
    public GameObject uICostField;
    public string stat;
    private Shop shop;

    
    void Start()
    {
        shop = GameObject.FindGameObjectWithTag("Templates").GetComponent<Shop>();
        uICost = uICostField.GetComponent<TMP_Text>();
        uICost.text = 0 + " €";
    }

    
    void Update()
    {
        switch (stat)
        {
            case "health":
                if (!uICost.text.Equals(shop.HealthCost() + " €"))
                {
                    uICost.text = shop.HealthCost() + " €";
                };
                break;
            case "damage":
                if (!uICost.text.Equals(shop.DamageCost() + " €"))
                {
                    uICost.text = shop.DamageCost() + " €";
                };
                break;
            case "range":
                if (!uICost.text.Equals(shop.RangeCost() + " €"))
                {
                    uICost.text = shop.RangeCost() + " €";
                };
                break;
            case "speed":
                if (!uICost.text.Equals(shop.SpeedCost() + " €"))
                {
                    uICost.text = shop.SpeedCost() + " €";
                };
                break;
        }
       
    }
}
