using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnAttack : MonoBehaviour
{
    private PlayerHealth playerHealth;
    public int damage;

    private void Start()
    {
        playerHealth = GameObject.FindObjectOfType<PlayerHealth>();
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.layer == 9)
        {
            playerHealth.DealDamage(damage);
        }
    }

}
