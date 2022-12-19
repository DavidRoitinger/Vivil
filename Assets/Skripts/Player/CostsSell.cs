using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CostsSell : MonoBehaviour
{
    
    public TMP_Text uICostS;
    public GameObject uICostSField;
    public string stat;
    private Shop shop;

    
    void Start()
    {
        shop = GameObject.FindGameObjectWithTag("Templates").GetComponent<Shop>();
        uICostS = uICostSField.GetComponent<TMP_Text>();
        uICostS.text = 0 + " €";
    }

    
    void Update()
    {
        switch (stat)
        {
            case "health":
                if (!uICostS.text.Equals(shop.HealthCost() - 50 + " €"))
                {
                    uICostS.text = shop.HealthCost() - 50 + " €";
                };
                break;
            case "damage":
                if (!uICostS.text.Equals(shop.DamageCost() - 50 + " €"))
                {
                    uICostS.text = shop.DamageCost() - 50 + " €";
                };
                break;
            case "range":
                if (!uICostS.text.Equals(shop.RangeCost() - 50 + " €"))
                {
                    uICostS.text = shop.RangeCost() - 50 + " €";
                };
                break;
            case "speed":
                if (!uICostS.text.Equals(shop.SpeedCost() - 50 + " €"))
                {
                    uICostS.text = shop.SpeedCost() - 50 + " €";
                };
                break;
        }
       
    }
}
