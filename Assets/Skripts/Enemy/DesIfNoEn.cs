using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesIfNoEn : MonoBehaviour
{
   
    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            if (checkNoEnemy())
            {
                Destroy(gameObject);
            }
            
        }
        
    }

    private bool checkNoEnemy()
    {
        if (GameObject.FindGameObjectWithTag("Enemy") == null) 
        {
           return true; 
        }
        return false;

    }
}
