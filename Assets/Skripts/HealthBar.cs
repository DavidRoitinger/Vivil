using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    
    public Slider slider;
    public Gradient gradient;
    public Image fill;


   
    public void SetMaxHealth(int health, int currentHealth)
    {
        slider.maxValue = health;
        slider.value = currentHealth;

        fill.color = gradient.Evaluate(1);
        
    }
    

    public void SetHealth(int health, int currentHealth)
    {
        slider.maxValue = health;
        slider.value = currentHealth;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

   
}
