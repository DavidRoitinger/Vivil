using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI5_1 : MonoBehaviour
{

    public GameObject curDub;
    public GameObject dub;
    public GameObject pFall;
    private Transform player;
    private EnHealth enHealth;
    private LaunchProjectiles launchProjectiles;
    private Shot tri;

    public int phase = 1;





    IEnumerator Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        launchProjectiles = GetComponent<LaunchProjectiles>();
        enHealth = GetComponent<EnHealth>();
        tri = gameObject.GetComponent<Shot>();


        yield return new WaitForSeconds(3);
        
        InvokeRepeating("Act", 0.0f, 10.0f);
    }


    void Update()
    {


    }

    void Act()
    {


        if (phase == 0)
        {

        }

        if (phase == 1)
        {
            
        }




    }
}

  
