using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI1 : MonoBehaviour
{
    Vector3 target;
    float dashTime = 1;
    bool dash = false;
    public float speed;
    private LaunchProjectiles launchProjectiles;
    public GameObject projectle;
    public GameObject projectleHom;
    private Transform player;
    private EnHealth enHealth;
    private int phase = 1;
    public GameObject drop;
    public GameObject dropEX;
    public GameObject particle;
    IEnumerator Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        launchProjectiles = gameObject.GetComponent<LaunchProjectiles>();
        enHealth = gameObject.GetComponent<EnHealth>();
        //target = new Vector3(transform.position.x, transform.position.y, 0);
        yield return new WaitForSeconds(3);
        
        InvokeRepeating("Move", 0.0f,1.0f);
    }

   
    void Update()
    {
      if(dash)
      {
            dashTime -= Time.deltaTime; 
            if (dashTime <= 0)
            {
                dash = false;
                dashTime = 1;
            }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * 3 * Time.deltaTime);
      }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

    }

     void Move()
     {
        if (enHealth.currentEnHealth <= 400 && phase == 1)
        {

            Instantiate(particle, transform.position, Quaternion.identity).transform.parent = gameObject.transform;
            phase = 2;
        }

        if (enHealth.currentEnHealth <= 250 && phase == 2)
        {
            Instantiate(particle, transform.position, Quaternion.identity).transform.parent = gameObject.transform;
            phase = 3;

        }

        if (phase == 0)
        {
            
        }

        if (phase == 1)
        {
            Phase1();
        }

        else if (phase == 2)
        {
            Phase2();
        }

        else if (phase == 3)
        {
            Phase3();
        }


        if (transform.position.x >= 11 || transform.position.y >= 5.5 || transform.position.x <= -11 || transform.position.y <= -5.5)
        {
                target = new Vector3(player.position.x, player.position.y, player.position.z);
                dash = true;
        }
        //yield return new WaitForSeconds(3);
    }

    public void Phase1()
    {
        switch (Random.Range(1, 12))
        {
            case 1:
                target = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
                break;

            case 2:
                target = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
                break;

            case 3:
                target = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
                break;

            case 4:
                target = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
                break;
            case 5:
                FindObjectOfType<AudioManager>().Play("EnShoot");
                launchProjectiles.attack(5, projectle);
                break;
            case 6:
                FindObjectOfType<AudioManager>().Play("EnShoot");
                launchProjectiles.attack(7, projectle);
                break;
            case 7:
                FindObjectOfType<AudioManager>().Play("EnShoot");
                launchProjectiles.attack(9, projectle);
                break;
            case 8:
                FindObjectOfType<AudioManager>().Play("EnShoot");
                launchProjectiles.attack(12, projectle);
                break;
            case 10:
                FindObjectOfType<AudioManager>().Play("WaveShoot");
                launchProjectiles.attack(5, projectleHom);
                break;
            case 11:
                FindObjectOfType<AudioManager>().Play("WaveShoot");
                target = new Vector3(player.position.x, player.position.y, player.position.z);
                dash = true;
                break;
        }
    }
    public void Phase2()
    {
        switch (Random.Range(1, 14))
        {
            case 1:
                Instantiate(drop, new Vector3(Random.Range(-11, 11), 15, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(drop, new Vector3(player.position.x + Random.Range(-0.5f, 0.5f), 15, 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(drop, new Vector3(player.position.x + Random.Range(-1, 1), 15, 0), Quaternion.identity);
                break;
            case 4:
                Instantiate(drop, new Vector3(player.position.x + Random.Range(-2, 2), 15, 0), Quaternion.identity);
                break;
            case 5:
                Instantiate(drop, new Vector3(player.position.x + Random.Range(-3, 3), 15, 0), Quaternion.identity);
                break;
            case 6:
                FindObjectOfType<AudioManager>().Play("EnShoot");
                launchProjectiles.attack(6, projectle);
                break;
            case 7:
                FindObjectOfType<AudioManager>().Play("EnShoot");
                launchProjectiles.attack(9, projectle);
                break;
            case 8:
                FindObjectOfType<AudioManager>().Play("EnShoot");
                launchProjectiles.attack(12, projectle);
                break;
            case 9:
                FindObjectOfType<AudioManager>().Play("EnShoot");
                launchProjectiles.attack(15, projectle);
                break;
            case 10:
                FindObjectOfType<AudioManager>().Play("WaveShoot");
                launchProjectiles.attack(6, projectleHom);
                break;
            case 11:
                FindObjectOfType<AudioManager>().Play("WaveShoot");
                launchProjectiles.attack(6, projectleHom);
                break;
            case 12:
                FindObjectOfType<AudioManager>().Play("WaveShoot");
                target = new Vector3(player.position.x, player.position.y, player.position.z);
                dash = true;
                break;
            case 13:
                FindObjectOfType<AudioManager>().Play("WaveShoot");
                target = new Vector3(player.position.x, player.position.y, player.position.z);
                dash = true;
                break;

        }
    }
    public void Phase3()
    {
        switch (Random.Range(1, 18))
        {
            case 1:
                Instantiate(drop, new Vector3(Random.Range(-11, 11), 30, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(drop, new Vector3(player.position.x + Random.Range(-0.5f, 0.5f), 30, 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(drop, new Vector3(player.position.x + Random.Range(-1, 1), 30, 0), Quaternion.identity);
                break;
            case 4:
                Instantiate(drop, new Vector3(player.position.x + Random.Range(-2, 2), 30, 0), Quaternion.identity);
                break;
            case 5:
                Instantiate(drop, new Vector3(player.position.x + Random.Range(-3, 3), 30, 0), Quaternion.identity);
                break;

            case 6:
                Instantiate(dropEX, new Vector3(Random.Range(-11, 11), -30, 0), Quaternion.identity);
                break;
            case 7:
                Instantiate(dropEX, new Vector3(player.position.x + Random.Range(-0.5f, 0.5f), -30, 0), Quaternion.identity);
                break;
            case 8:
                Instantiate(dropEX, new Vector3(player.position.x + Random.Range(-1, 1), -30, 0), Quaternion.identity);
                break;
            case 9:
                Instantiate(dropEX, new Vector3(player.position.x + Random.Range(-2, 2), -30, 0), Quaternion.identity);
                break;
            case 10:
                Instantiate(dropEX, new Vector3(player.position.x + Random.Range(-3, 3), -30, 0), Quaternion.identity);
                break;
      
            case 12:
                FindObjectOfType<AudioManager>().Play("EnShoot");
                launchProjectiles.attack(12, projectle);
                break;
            case 13:
                FindObjectOfType<AudioManager>().Play("EnShoot");
                launchProjectiles.attack(15, projectle);
                break;

            case 14:
                FindObjectOfType<AudioManager>().Play("WaveShoot");
                launchProjectiles.attack(6, projectleHom);
                break;
            case 15:
                FindObjectOfType<AudioManager>().Play("WaveShoot");
                launchProjectiles.attack(6, projectleHom);
                break;

            case 16:
                FindObjectOfType<AudioManager>().Play("WaveShoot");
                target = new Vector3(player.position.x, player.position.y, player.position.z);
                dash = true;
                break;
            case 17:
                FindObjectOfType<AudioManager>().Play("WaveShoot");
                target = new Vector3(player.position.x, player.position.y, player.position.z);
                dash = true;
                break;
        }

       
    }
}
