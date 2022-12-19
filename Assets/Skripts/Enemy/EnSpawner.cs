using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnSpawner : MonoBehaviour
{
    public RoomTemplates en;
    public GameObject horDoor;
    public GameObject verDoor;
    private GameObject[] doors = new GameObject[4];
    public Transform target;
    private int rand;
    private bool spawned;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        en = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
       
        
    }

    private void Update()
    {
        if (!spawned)
        {
            if (Vector2.Distance(transform.position, target.position) < 4)
            {
                spawn();

                Instantiate(horDoor, new Vector3(transform.position.x - 4.5f, transform.position.y, transform.position.z), Quaternion.identity);
                Instantiate(horDoor, new Vector3(transform.position.x + 4.5f, transform.position.y, transform.position.z), Quaternion.identity);
                Instantiate(verDoor, new Vector3(transform.position.x, transform.position.y - 4.5f, transform.position.z), Quaternion.identity);
                Instantiate(verDoor, new Vector3(transform.position.x, transform.position.y + 4.5f, transform.position.z), Quaternion.identity);

                spawned = true;

            }
        }
        else
        { 
            doors = GameObject.FindGameObjectsWithTag("Destroy");

            if (GameObject.FindGameObjectWithTag("Enemy") == null)
            {
                
                Destroy(doors[0]);
                Destroy(doors[1]);
                Destroy(doors[2]);
                Destroy(doors[3]);
            }
        }


    }


    void spawn()
    {
        rand = Random.Range(0, en.enemys.Length);
        Instantiate(en.enemys[rand], transform.position, en.enemys[rand].transform.rotation);
       
    }
    


}
