using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Boss7Grav : MonoBehaviour
{
    public float speed;
    public Transform target;

    
    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.3f);
            transform.localScale = new Vector3(transform.localScale.x+0.003f, transform.localScale.y + 0.003f, transform.localScale.z);
            speed += 0.02f;
        }
        
    }

    void FixedUpdate()
    {
        
        
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().AddForce(new Vector2(transform.position.x - target.position.x, transform.position.y - target.position.y)*speed);
    }

}
