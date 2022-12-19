using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level : MonoBehaviour
{

    public TMP_Text uILevel;
    public GameObject uILevelField;
    public string stat;
    private Shop shop;


    void Start()
    {
        shop = GameObject.FindGameObjectWithTag("Templates").GetComponent<Shop>();
        uILevel = uILevelField.GetComponent<TMP_Text>();
        uILevel.text = 0 + " €";
    }


    void Update()
    {
        switch (stat)
        {
            case "health":
                if (!uILevel.text.Equals(shop.HealthCost()/50 + " Lvl."))
                {
                    uILevel.text = shop.HealthCost()/50 + " Lvl.";
                };
                break;
            case "damage":
                if (!uILevel.text.Equals(shop.DamageCost()/50 + " Lvl."))
                {
                    uILevel.text = shop.DamageCost()/50 + " Lvl.";
                };
                break;
            case "range":
                if (!uILevel.text.Equals((int) shop.RangeCost()/50 + " Lvl."))
                {
                    uILevel.text = (int) shop.RangeCost()/50 + " Lvl.";
                };
                break;
            case "speed":
                if (!uILevel.text.Equals((int) shop.SpeedCost()/50 + " Lvl."))
                {
                    uILevel.text = (int) shop.SpeedCost()/50 +  " Lvl.";
                };
                break;
        }

    }
}
