using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBullets : MonoBehaviour
{
   
    public GameObject newBullet;

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
       // PlShoot.plBulletPrefab = newBullet;
    }
}
