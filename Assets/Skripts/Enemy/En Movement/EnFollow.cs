using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnFollow : MonoBehaviour
{
    public float speed;
    public Transform target;
    public float goDis;
    public float stopDis;

   
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) < goDis)
        {

            if (Vector2.Distance(transform.position, target.position) > stopDis)
            {

                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

            }

        }
       
    }

}
