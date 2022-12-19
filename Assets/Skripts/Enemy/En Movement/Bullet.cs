using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Transform player;
    Vector2 target;
    public float bulSpeed;
    public bool split;
    private LaunchProjectiles launchProjectiles;

    public float lifeTime;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        launchProjectiles = gameObject.GetComponent<LaunchProjectiles>();
        target = new Vector2(player.position.x, player.position.y);
    }
    private void Update()
    {
        lifeTime -= Time.deltaTime;
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
        if (split)
        {
            FindObjectOfType<AudioManager>().Play("Explosion");
            launchProjectiles.attack();
        }

        Destroy(gameObject);
    }
}
