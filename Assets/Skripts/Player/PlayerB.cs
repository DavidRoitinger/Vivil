using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerB : MonoBehaviour
{

    public static float moveSpeed = 7f;
    private float speed;

    private Rigidbody2D rigCom;
    private Vector2 movement;
  

    // Start is called before the first frame update
    void Start()
    {
        rigCom = GetComponent<Rigidbody2D>();
        speed = moveSpeed;
    }

    // Update is called once per frame
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
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("lol");
            rigCom.velocity = Vector2.up * 1000;
        }
        
        movement.x = Input.GetAxisRaw("Horizontal");
    }

    private void move()
    {
        rigCom.MovePosition(rigCom.position + movement * speed /100);
    }

   


}