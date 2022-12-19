using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public int heal;
    public int plusHealth;
    public int plusDamage;
    public float minCool;
    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Stats.currentHealth += heal;
        Stats.maxHealth += plusHealth;
        Stats.damage += plusDamage;
        Stats.plCooldown = Stats.plCooldown / minCool;
        Destroy(gameObject);
    }
}
