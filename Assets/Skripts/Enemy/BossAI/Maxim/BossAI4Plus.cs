using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI4Plus : MonoBehaviour
{
    private LightEn lightEn;
    private Move move;
    private Transform playerPos;
    public Animator midWall;
    private bool start = false;
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        lightEn = gameObject.GetComponent<LightEn>();
        move = gameObject.GetComponent<Move>();
        move.Ready = true;
        
    }

    private void Update()
    {
        if (midWall != null && midWall.GetBool("resumeFall"))
        {
            gameObject.transform.position = new Vector3(0, 0, 0);
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            start = true;
        }
        else
        {
            lightEn.Shoot = false;
        }
    }

    void FixedUpdate()
    {
        if (start)
        {
            if (gameObject.transform.position.x >= playerPos.position.x)
            {
                move.SpeedX = -0.5f;
                move.Ready = true;
            }
            else
            {
                move.SpeedX = 0.5f;
                move.Ready = true;
            }

            if (gameObject.transform.position.y >= playerPos.position.y)
            {
                move.SpeedY = -0.5f;
                move.Ready = true;
            }
            else
            {
                move.SpeedY = 0.5f;
                move.Ready = true;
            }
        }
        
    }

}
