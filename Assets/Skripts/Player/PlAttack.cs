using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlAttack : MonoBehaviour
{
   
    

    

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.layer == 8)
        {
            if (other.gameObject.GetComponent<EnColHealth>() != null)
            {
                other.gameObject.GetComponent<EnColHealth>().DealEnDamage(Stats.damage);
            }
            if(other.gameObject.GetComponent<EnHealth>() != null)
            { 
                 other.gameObject.GetComponent<EnHealth>().DealEnDamage(Stats.damage);
            }
           
        }
    }

}
