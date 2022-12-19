using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    private bool sOpen = false;

    public GameObject shopMenu;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
          
            if (sOpen)
            {
                Close();
                sOpen = false;
            }
            else
            {
                Open();
                sOpen = true;
            }
        }
    }



    public void Close()
    {
        
        shopMenu.SetActive(false);
    }

    public void Open()
    {
        
        shopMenu.SetActive(true);
    }





    public int HealthCost()
    {
        int hCost = (Stats.maxHealth - 75) * 2;
        return hCost;
    }

    public void HealthPlus()
    {
        
        if (Stats.money >= HealthCost())
        {
            Stats.money -= HealthCost();
            Stats.currentHealth += 25;
            Stats.maxHealth += 25;
        }

    }
    public void HealthMinus()
    {
       
        if (HealthCost() > 0)
        {
            Stats.money += HealthCost() - 50;
            Stats.currentHealth -= 25;
            Stats.maxHealth -= 25;
        }
    }




    public int DamageCost()
    {
        int dCost =  (Stats.damage - 4) * 50;
        return dCost;
    }

    public void DamagePlus()
    {
        
        if (Stats.money >= DamageCost())
        {
            Stats.money -= DamageCost();
            Stats.damage += 1;
            
        }
        
    }

    public void DamageMinus()
    {
        
        if (DamageCost() > 0)
        {
            Stats.money += DamageCost() - 50;
            Stats.damage -= 1;
            
        }

    }




    public int RangeCost()
    {
        int rCost = (int)((Stats.range - 0.75f) * 200);
        return rCost;
    }

    public void RangePlus()
    {
        
        if (Stats.money >= RangeCost())
        {
            Stats.money -= RangeCost();
            Stats.range += 0.25f;
            
        }

    }
    public void RangeMinus()
    {
        
        if (RangeCost() > 0)
        {
            Stats.money += RangeCost() - 50;
            Stats.range -= 0.25f;
            
        }

    }




    public int SpeedCost()
    {
        int rCost = (int)((Stats.moveSpeed - 4.5f) * 100);
        return rCost;
    }

    public void SpeedPlus()
    {
        
        if (Stats.money >= SpeedCost())
        {
            Stats.money -= SpeedCost();
            Stats.moveSpeed += 0.5f;
        }

    }
    public void SpeedMinus()
    {
        
        if (SpeedCost() > 0)
        {
            Stats.money += SpeedCost() - 50;
            Stats.moveSpeed -= 0.5f;
        }

    }

}


