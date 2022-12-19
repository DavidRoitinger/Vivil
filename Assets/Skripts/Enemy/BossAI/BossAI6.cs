using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI6 : MonoBehaviour
{
    public GameObject bullet;
    

    private Transform player;
    private EnHealth enHealth;
    private int phase = 1;
    private bool phaseChange = false;
    private float lookAngle;
    private Vector3 lookDirection;
    private Shot shot;



    IEnumerator Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enHealth = gameObject.GetComponent<EnHealth>();
        shot = gameObject.GetComponent<Shot>();


        yield return new WaitForSeconds(1);
        
        while (true)
        {
            Akt();
            if (phase == 1) yield return new WaitForSeconds(3f + Random.Range(-1f,1f));
            if (phase == 2) yield return new WaitForSeconds(2f + Random.Range(-1f, 1f));
            if (phase == 3) yield return new WaitForSeconds(1f + Random.Range(-1f, 1f));
            if (phaseChange) 
            {
                phase++;
            } 
        }
        
    }

   
    void Update()
    {
        lookDirection = new Vector3(player.transform.position.x, player.transform.position.y) - new Vector3(transform.position.x, transform.position.y);
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, lookAngle-135);

    }

    void Akt()
     {
        if (enHealth.currentEnHealth <= 100 && phase == 1) phaseChange = true;

        if (enHealth.currentEnHealth <= 50 && phase == 2) phaseChange = true;

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

    private void Phase1()
    {
        shot.Shoot(bullet); 
    }
    private void Phase2()
    {
        shot.Shoot(bullet);
    }
    private void Phase3()
    {
        shot.Shoot(bullet);
    }
}
