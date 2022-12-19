using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXFollow : MonoBehaviour
{
    public EnHealth enHealth;
    public float speed;
    public Transform target;
    
   
    void Start()
    {
        enHealth = GameObject.FindObjectOfType<EnHealth>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

   
    void Update()
    {
        if(enHealth.currentEnHealth <= 25)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        
    }
}
