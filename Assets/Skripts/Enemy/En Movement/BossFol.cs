using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFol : MonoBehaviour
{
    public float speed;
    public Transform target;
    Rigidbody2D rigCom;
    Vector2 movement;


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        rigCom = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        processInputs();
    }

    void FixedUpdate()
    {
        move();
    }

    void processInputs()
    {
        
        movement.x = target.position.x - transform.position.x;
        movement.y = target.position.y - transform.position.y;
    }

    private void move()
    {
        rigCom.MovePosition(rigCom.position + movement * speed );
    }
}
