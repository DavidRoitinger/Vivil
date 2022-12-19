using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnDeath : MonoBehaviour
{
    public GameObject portal;
    private bool spawend;
    
    void Update()
    {
        
        if(GameObject.FindGameObjectWithTag("Enemy") == null && !spawend)
        {
            Instantiate(portal, transform.position, Quaternion.identity);
            spawend = true;
        }
    }
}
