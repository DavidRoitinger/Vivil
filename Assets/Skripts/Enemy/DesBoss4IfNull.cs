using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesBoss4IfNull : MonoBehaviour
{
   
    public GameObject keyObject;

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.3f);
            if (checkNull())
            {
                yield return new WaitForSeconds(3f);
                Animator a = gameObject.GetComponent<Animator>();
                a.SetBool("resumeFall", true);
                yield return new WaitForSeconds(2);
                Destroy(gameObject);
            }
            
        }
        
    }

    private bool checkNull()
    {
        if (keyObject == null) 
        {
           return true; 
        }
        return false;

    }
}
