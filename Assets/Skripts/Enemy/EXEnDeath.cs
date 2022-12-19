using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXEnDeath : MonoBehaviour
{
    bool spwaned;
    public GameObject portal;
    


    private void Start()
    {
        
    }
    void Update()
    {
       if (Stats.currentHealth < 20)
       {
            if (GameObject.FindGameObjectWithTag("Enemy") == null && !spwaned)
            {
                Instantiate(portal, transform.position, Quaternion.identity);
                spwaned = true;
            }
        }

    }
}
