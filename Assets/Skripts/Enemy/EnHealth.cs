using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnHealth : MonoBehaviour
{
    public GameObject body;
    public HealthBar healthBar;
    public int currentEnHealth;
    public int maxEnHealth;
    public int dropMoney;
    public bool noFlash;
    private float flashTime;
    private SpriteRenderer sR;
    
    void Start()
    {
        if(body == null)
        {
            body = gameObject;
        }

        maxEnHealth = currentEnHealth;
        if(healthBar != null)
        {
            setHealthBar(healthBar);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (flashTime >= 0 && !noFlash)
        {
            flashTime -= Time.deltaTime;
            if(flashTime <= 0)
            {
                endDFlash();
            }
        } 
        
        
        if (healthBar != null)
        {
            healthBar.SetHealth(maxEnHealth, currentEnHealth);
        }
        if (currentEnHealth <= 0)
        {
            FindObjectOfType<AudioManager>().Play("EnDeath");
            EnDeath();
        }
       

        
    }

    

    public void DealEnDamage(int damage)
    {
        
            FindObjectOfType<AudioManager>().Play("EnHurt", true);

        if (!noFlash)
        {
            body.GetComponent<SpriteRenderer>().color = Color.gray;

            flashTime = 0.05f;
        }
           


            currentEnHealth -= damage;
    }

    public void endDFlash()
    {
        body.GetComponent<SpriteRenderer>().color = Color.black;
    }



    private void EnDeath()
    {
        Stats.money += dropMoney;
        if(body != null)
        {
            Destroy(body);
        }
        Destroy(gameObject);
        
    }

    public void setHealthBar(HealthBar healthBar)
    {
      
        healthBar.SetMaxHealth(maxEnHealth, currentEnHealth);
        this.healthBar = healthBar;
    }

}
