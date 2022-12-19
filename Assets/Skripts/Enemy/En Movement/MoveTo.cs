using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    public float x;
    public float y;
    private Vector2 dir;
    private Vector2 nDir;
    private EnHealth bossHealth;
    private int lastHealth;

    public void Start()
    {
        bossHealth = GetComponent<EnHealth>();
        lastHealth = bossHealth.currentEnHealth;
        dir = new Vector2(x, y);
        nDir = new Vector2(-x, -y);
    }

    void FixedUpdate()
    {
        if (transform.position.x <= -2)
        { 
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            GetComponent<Rigidbody2D>().AddForce(nDir * 50);
            return;
        }
        
        if (transform.position.x <= 0)
        {
            if (lastHealth > bossHealth.currentEnHealth)
            {
                
                GetComponent<Rigidbody2D>().AddForce(nDir * 50);
                lastHealth = bossHealth.currentEnHealth;
                return;
            }
            GetComponent<Rigidbody2D>().AddForce(dir * 0.5f);
            return;
        }
        if (lastHealth > bossHealth.currentEnHealth)
        {
            GetComponent<Rigidbody2D>().AddForce(nDir  * 10);
            lastHealth = bossHealth.currentEnHealth;
            return;        
        }
       
        GetComponent<Rigidbody2D>().AddForce(dir);

    }

}
