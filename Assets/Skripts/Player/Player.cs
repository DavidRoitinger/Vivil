using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{

   
    private float speed;

    Rigidbody2D rigCom;
    Vector2 movement;
  

    // Start is called before the first frame update
    void Start()
    {
        rigCom = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = Stats.moveSpeed;
        processInputs();
    }

    void FixedUpdate()
    {
        move();
    }

    void processInputs()
    {
        movement.x = Input.GetAxisRaw("Horizontal");

        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void move()
    {
        rigCom.MovePosition(rigCom.position + movement * speed *Time.deltaTime);
    }

   


}