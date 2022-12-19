using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI3 : MonoBehaviour
{
   
    
    

    private Transform player;
    public EnHealth enHealth;
    private LaunchProjectiles launchProjectiles;
    private Shot tri;

    public int phase = 1;
    
   
    
    

    IEnumerator Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        launchProjectiles = gameObject.GetComponent<LaunchProjectiles>();
        enHealth = GetComponent<EnHealth>();
        tri = gameObject.GetComponent<Shot>();
        launchProjectiles.attack(20);

        yield return new WaitForSeconds(3);

        InvokeRepeating("Act", 0.0f,2.0f);
    }

   
    void Update()
    {
      
        
    }

     void Act()
     {
        if (enHealth.currentEnHealth <= 200 && phase == 1)
        {
            launchProjectiles.attack(20);
            //Instantiate(particle, transform.position, Quaternion.identity);
            phase = 2;
        }

        if (enHealth.currentEnHealth <= 150 && phase == 2)
        {
            launchProjectiles.attack(20);
            launchProjectiles.attack(20);
            phase = 3;
        }

        if (enHealth.currentEnHealth <= 75 && phase == 3)
        {
            launchProjectiles.attack(30);
            launchProjectiles.attack(30);
            phase = 4;
            

        }

        if (phase == 0)
        {
            
        }

        if (phase == 1)
        {
            Phase1();
        }

        else if (phase == 2)
        {
            Phase2();
        }

        else if (phase == 3)
        {
            Phase3();
        }

        else if (phase == 4)
        {
            Phase4();
        }



    }

    public void Phase1()
    {
        
    }
    public void Phase2()
    {
        
    }
    public void Phase3()
    {
        launchProjectiles.attack(1);
    }
    public void Phase4()
    {
        launchProjectiles.attack(2);
    }

}
