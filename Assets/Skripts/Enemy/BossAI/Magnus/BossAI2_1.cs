using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI2_1 : MonoBehaviour
{

    Vector3 target;

    BossAI2 bossAI2;

    public float speed;
    
    

    void Start()
    {
        bossAI2 = GameObject.FindGameObjectWithTag("ColEnemy").GetComponent<BossAI2>();
       

        
    }

   
    void Update()
    {

        if (bossAI2.phase == 0 || bossAI2.phase == 3)
        {
            target = new Vector3(0, 0, 0);
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
        else if (bossAI2.phase == 2)
        {
            target = new Vector3(0, 6, 0);
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
        else
        {
            target = new Vector3(0, 8, 0);
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }

        if (bossAI2.enHealth.currentEnHealth <= 0)
        {
            Destroy(gameObject);
        }


    }

   
   
    
}
