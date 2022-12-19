using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    public List<GameObject> rooms;

    public GameObject closedRoom;

    public float waitTime;
    bool spawnedPortal;
    public GameObject portal;

    public GameObject[] enemys;

    /*private void Update()
    {
        if (waitTime <= 0)
        {
            if(!spawnedPortal)
            {
                Instantiate(portal, rooms[rooms.Count - 1].transform.position, Quaternion.identity);
                spawnedPortal = true;
            }
            
        }

        else
        {
            waitTime -= Time.deltaTime;
        }

    }*/
}
    

