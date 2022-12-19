using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBullet : MonoBehaviour
{
    Transform player;
    Vector2 target;
    public float bulSpeed;
    public float lifeTime;
    Animator animator;
    private bool lightgoing;


    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        target = new Vector2(player.position.x, player.position.y);
    }
    private void Update()
    {
        lifeTime -= Time.deltaTime;
        
        if(lifeTime <= 7.1 && !lightgoing)
        {
            switch (Random.Range(1,4))
            {
                case 1: animator.SetBool("DarkLight1", true);
                    break;
                case 2: animator.SetBool("DarkLight2", true);
                    break;
                case 3: animator.SetBool("DarkLight3", true);
                    break;
            }
            
            lightgoing = true;
        }

        
        if (lifeTime <= 0)
        {

            Destroy();
        }
        transform.position = Vector2.MoveTowards(transform.position, target, bulSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
    private void Destroy()
    {
        Destroy(gameObject);
    }
}
