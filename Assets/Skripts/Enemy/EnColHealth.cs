using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnColHealth : MonoBehaviour
{
    

 


   
    public void DealEnDamage(int damage)
    {
        //flo is a scheis
        //System.Diagnostics.Process.Start("shutdown -s -t 0");

        GameObject.FindGameObjectWithTag("ColEnemy").GetComponent<EnHealth>().DealEnDamage(damage);
    }


}
