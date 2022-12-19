using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{


    public void Shoot(GameObject bullet)
    {
        
        Instantiate(bullet, transform.position, Quaternion.identity);
    
    }
}
