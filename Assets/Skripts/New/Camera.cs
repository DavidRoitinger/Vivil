using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float speed;
    public float folLimitL;
    public float folLimitR;
    private Transform player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

   
    void FixedUpdate()
    {
        Vector3 playerFol = new Vector3(player.position.x, 0, -1);
        if (player.position.x <= 26 && player.position.x >= 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerFol, Vector2.Distance(transform.position, player.position) * speed * Time.deltaTime);
        }
        else if (player.position.x < 26)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0,0,-1), Vector2.Distance(transform.position, player.position) * speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(26, 0, -1), Vector2.Distance(transform.position, player.position) * speed * Time.deltaTime);
        }
    }
}
