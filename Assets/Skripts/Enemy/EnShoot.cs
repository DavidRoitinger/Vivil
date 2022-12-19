using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnShoot : MonoBehaviour
{
    public GameObject bullet;
   
    public float startCooldown;
    private float cooldown;
    private Transform target;
    public float shootDis;
    

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        cooldown = startCooldown;
    }

    
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Vector2.Distance(transform.position, target.position) < shootDis)
        {
             if (cooldown <= 0)
             {
                FindObjectOfType<AudioManager>().Play("EnShoot");
                Instantiate(bullet, transform.position, Quaternion.identity);
                 cooldown = startCooldown;
             }
             else
             {
                  cooldown -= Time.deltaTime;
             }
        }
    }
}
