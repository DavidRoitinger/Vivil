using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    public HealthBar healthBar;
    public GameObject scene;
    public GameObject deathScreen;
    private PlShoot ps;

    void Start()
    {
        ps = GetComponent<PlShoot>();
    }

    void Update()
    {
        if(Stats.currentHealth > Stats.maxHealth)
        {
            Stats.currentHealth = Stats.maxHealth;
        }

        healthBar.SetHealth(Stats.maxHealth, Stats.currentHealth);
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(Stats.currentHealth > 25) 
            { 
                DealDamage(25);
                ps.ExShoot();
            }
           
            
        } else if (Input.GetKeyDown(KeyCode.E))
        {
            if (Stats.money >= 50)
            {
                DealDamage(-50);
                Stats.money -= 50;
            }
            
        }
        if(Stats.currentHealth <= 0)
        {
            PlayerDeath();
        }
    }
    
    public void DealDamage(int damage)
    {
        FindObjectOfType<AudioManager>().Play("Hurt");
        Stats.currentHealth -= damage;
    }

    public void PlayerDeath()
    {
        scene.SetActive(false);
        deathScreen.SetActive(true);
        Stats.money /= 2;
        Stats.currentHealth = 100;
        /*
        maxHealth = 100;
        PlAttack.damage = 5;
        PlBullet.range = 1;
        Player.moveSpeed = 7f;
        
        */
    }

}
