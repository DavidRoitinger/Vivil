using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI5_2 : MonoBehaviour
{

    
    private Transform Neo;
    

    public void Start()
    {
        Neo = GameObject.FindGameObjectWithTag("Pos").GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        

        transform.position = Vector2.MoveTowards(transform.position, new Vector2(Neo.position.x, Neo.position.y), 0.25f);

        if(Neo == transform)
        {
            Destroy(gameObject);
        }

    }

    
}

  
