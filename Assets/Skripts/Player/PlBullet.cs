using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlBullet : MonoBehaviour
{
   
    
    private float lifeTime;


    private void Start()
    {
        lifeTime = Stats.range;
    }
    private void Update()
    {
         lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy();
        }
    
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 8)
        {
            Destroy();
        }
    }
    private void Destroy()
    {
        Destroy(gameObject);
    }
}
