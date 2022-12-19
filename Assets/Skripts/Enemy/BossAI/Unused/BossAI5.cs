using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI5 : MonoBehaviour
{
    public HealthBar smallHb;
    public GameObject kromer;
    private GameObject curNeo;
    public GameObject Neo;
    private GameObject curDub;
    public GameObject dub;
    public GameObject pFall;
    private Transform player;
    private EnHealth enHealth;
    private LaunchProjectiles launchProjectiles;
    private Shot tri;
    private float count;
    public int phase = 1;
   

    IEnumerator Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        launchProjectiles = GetComponent<LaunchProjectiles>();
        enHealth = GetComponent<EnHealth>();
        tri = gameObject.GetComponent<Shot>();
       

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
            GetComponent<Rigidbody2D>().gravityScale = -10;

            NewDub();
            dub.GetComponent<EnHealth>().setHealthBar(smallHb);
            phase = 2;
        }

        else if (curDub == null && phase == 2)
        {
            GetComponent<Rigidbody2D>().gravityScale = 2;
            count = 5;
            phase = 3;
        }

        else if (enHealth.currentEnHealth <= 75 && phase == 3)
        {
            GetComponent<Rigidbody2D>().gravityScale = -10f;
            NewNeo();
            curNeo.GetComponent<EnHealth>().setHealthBar(smallHb);
            phase = 4;
        }

        else if (curNeo == null && phase == 4)
        {
            GetComponent<Rigidbody2D>().gravityScale = 2;

            
            phase = 5;
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

        else if (phase == 5)
        {
            Phase5();
        }



    }

    public void Phase1()
    {
        //aktiv

        if (player.position.y > 0 && Random.Range(0, 5) > 3)
        {
            PFall();
            return;
        }
        switch (Random.Range(1, 13))
        {
            case 1:
                
                break;
            case 2:
                PFall();
                break;
            case 3:
                
                break;
            case 4:
               
                break;
            case 5:
                
                break;
            case 6:
                
                break;
            case 7:
                
                break;
            case 8:
                
                break;
            case 10:
                
                break;
            case 11:
                
                break;
            case 12:
                
                break;
        }
        
    }
    public void Phase2()
    {
        //hidden

        if (player.position.y > 0 && Random.Range(0, 5) > 2)
        {
            PFall();
            return;
        }
        switch (Random.Range(1, 13))
        {
            case 1:
                
                break;
            case 2:
               
                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
            case 7:

                break;
            case 8:

                break;
            case 10:

                break;
            case 11:

                break;
            case 12:

                break;
        }
    }
    public void Phase3()
    {
        //aktiv
        
        switch (Random.Range(1, 13))
        {
            case 1:
                
                break;
            case 2:
                PFall();
                break;
            case 3:
                PFall();
                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
            case 7:

                break;
            case 8:

                break;
            case 10:

                break;
            case 11:

                break;
            case 12:

                break;
        }
    }
    public void Phase4()
    {
        //hidden

        NewKromer();
        NewKromer();
        NewKromer();


    }
    public void Phase5()
    {
        //hidden
        if (curDub == null && Random.Range(0, 15) > 13)
        {
            NewDub();
            return;
        }
        switch (Random.Range(1, 13))
        {
            case 1:
                
                break;
            case 2:
                PFall();
                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
            case 7:

                break;
            case 8:

                break;
            case 10:

                break;
            case 11:

                break;
            case 12:

                break;
        }
    }

    public void PFall()
    {
        Instantiate(pFall, new Vector2(0, 3.5f), Quaternion.identity);
    }
    public void NewDub()
    {
        curDub = Instantiate(dub, new Vector2(5,3.5f), Quaternion.identity);
    }
    public void NewNeo()
    {
        curNeo = Instantiate(Neo, new Vector2(22, -7.5f), Quaternion.identity);
    }
    public void NewKromer()
    {
        curNeo = Instantiate(kromer, new Vector2(Random.Range(-30, -22), Random.Range(-5,10)), Quaternion.identity);
    }

    
}
