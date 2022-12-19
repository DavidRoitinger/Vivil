using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Money : MonoBehaviour
{
    
    public TMP_Text UIMoney;
    public GameObject UIMoneyField;

    
    void Start()
    {
        UIMoney = UIMoneyField.GetComponent<TMP_Text>();
        UIMoney.text = Stats.money + " €";
    }

    void Update()
    {
        if(!UIMoney.text.Equals(Stats.money + " €"))
        {
            UIMoney.text = Stats.money + " €";
        }
    }
}
