using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI4 : MonoBehaviour
{   
    public float speed;
    private Transform player;
    private EnHealth enHealth;
    private int phase = 1;
    private bool phaseChange = false;
    //public GameObject particle;
    public GameObject weakPointL;
    public GameObject weakPointR;
    public GameObject weakPointLS;
    public GameObject weakPointRS;
    public GameObject wallL;
    public GameObject wallR;
    public GameObject wallLS;
    public GameObject wallRS;
    public Animator wallMidAni;


    IEnumerator Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
        enHealth = gameObject.GetComponent<EnHealth>();
        //target = new Vector3(transform.position.x, transform.position.y, 0);
        yield return new WaitForSeconds(3);
        
        while (true)
        {
            Akt();
            if (phase == 1) yield return new WaitForSeconds(1);
            if (phase == 2) yield return new WaitForSeconds(0.75f);
            if (phase == 3) yield return new WaitForSeconds(0.75f);
            if (phaseChange) 
            {
                yield return new WaitForSeconds(5f); phaseChange = false; phase++;
                if (phase == 3)
                {
                    wallMidAni.SetBool("startFall", true);
                } 
                
            } 
        }
        
    }

   
    void Update()
    {

    }

     void Akt()
     {
        if (enHealth.currentEnHealth <= 400 && phase == 1) phaseChange = true;

        if (enHealth.currentEnHealth <= 200 && phase == 2) phaseChange = true;

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
        float rand = Random.Range(-10, 5);
        Instantiate(wallL, new Vector2(-16,rand), Quaternion.identity);
        if (rand < -3 && rand > -9 && Random.Range(0, 10)>3)
        {
            Instantiate(weakPointL, new Vector2(-16,rand+6), Quaternion.identity);
        }
        
    }
    private void Phase2()
    {
        float rand = Random.Range(-10, 5);
        Instantiate(wallR, new Vector2(16, rand), Quaternion.identity);
        if (rand < -3 && rand > -9 && Random.Range(0, 10) > 3)
        {
            Instantiate(weakPointR, new Vector2(16, rand + 6), Quaternion.identity);
        }
    }
    private void Phase3()
    {
        float rand1 = Random.Range(-10, 5);
        Instantiate(wallLS, new Vector2(-16, rand1), Quaternion.identity);
        if (rand1 < -3 && rand1 > -9 && Random.Range(0, 10) > 3)
        {
            Instantiate(weakPointLS, new Vector2(-16, rand1 + 6), Quaternion.identity);
        }
        float rand2 = Random.Range(-10, 5);
        Instantiate(wallRS, new Vector2(16, rand2), Quaternion.identity);
        if (rand2 < -3 && rand2 > -9 && Random.Range(0, 10) > 3)
        {
            Instantiate(weakPointRS, new Vector2(16, rand2 + 6), Quaternion.identity);
        }

    }
}
