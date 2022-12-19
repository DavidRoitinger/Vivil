using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnFolPhys : MonoBehaviour
{
    public float speed;
    public Transform target;
    private float lookAngle;
    private Vector3 lookDirection;
    
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    
    void FixedUpdate()
    {
        lookDirection = new Vector3(target.transform.position.x, target.transform.position.y) - new Vector3(transform.position.x, transform.position.y);
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, lookAngle);
        gameObject.GetComponent<Rigidbody2D>().AddForce(lookDirection * speed);
    }

}
