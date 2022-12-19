using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI2 : MonoBehaviour
{
   
    public GameObject saw;
    public GameObject BigSaw;
    public GameObject BossSaw;
    public GameObject particle;

    private Transform player;
    public EnHealth enHealth;
    private LaunchProjectiles launchProjectiles;

    public int phase = 1;
    
   
    
    

    IEnumerator Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        launchProjectiles = gameObject.GetComponent<LaunchProjectiles>();
        enHealth = GetComponent<EnHealth>();

        yield return new WaitForSeconds(3);

        InvokeRepeating("Act", 0.0f,1.0f);
    }

   
    void Update()
    {
      
        
    }

     void Act()
     {
        if (enHealth.currentEnHealth <= 550 && phase == 1)
        {
            Instantiate(particle, transform.position, Quaternion.identity);
            phase = 2;
        }

        if (enHealth.currentEnHealth <= 300 && phase == 2)
        {
            Instantiate(particle, transform.position, Quaternion.identity);
            phase = 0;
        }

        if (enHealth.currentEnHealth <= 250 && phase == 0)
        {
            Instantiate(particle, transform.position, Quaternion.identity);
            phase = 3;

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


        
    }

    public void Phase1()
    {
        switch (Random.Range(1, 2))
        {
            case 1:
                Instantiate(saw, new Vector3(Random.Range(-11,11),10,0), Quaternion.identity);
                break;
        }
    }
    public void Phase2()
    {
        switch (Random.Range(1, 2))
        {
            case 1:
                Instantiate(BigSaw, new Vector3(Random.Range(-11, 11), -10, 0), Quaternion.identity);
                break;
        }
    }
    public void Phase3()
    {
        launchProjectiles.attack(Random.Range(3,9));        
     
    }
    
}
