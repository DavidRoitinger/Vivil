using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlShoot : MonoBehaviour
{
    //public static GameObject plBulletPrefab;
    public GameObject plBulletPrefab;
    public GameObject plBulletPrefabEX;
    
    private LaunchProjectiles lp;
    float plLastFire;
   
    float shootVer;
    float shootHor;
    

    void Start()
    {
        lp = GetComponent<LaunchProjectiles>();
    }


    void Update()
    {
        shootVer = Input.GetAxis("Shoot/Vertical");
        shootHor = Input.GetAxis("Shoot/Horizontal"); ;

        if ((shootHor != 0 || shootVer != 0) && Time.time > plLastFire + Stats.plCooldown)
        {
            FindObjectOfType<AudioManager>().Play("PlShoot", true);
            Shoot(shootHor, shootVer);
            plLastFire = Time.time;
        }
            
    }

    void Shoot(float x, float y)
    {
        GameObject plBullet = Instantiate(plBulletPrefab, transform.position, transform.rotation) as GameObject;
        plBullet.AddComponent<Rigidbody2D>().gravityScale = 0;
        plBullet.GetComponent<Rigidbody2D>().velocity = new Vector3
        (
            (x < 0) ? Mathf.Floor(x) * Stats.plBulletSpeed : Mathf.Ceil(x) * Stats.plBulletSpeed,
            (y < 0) ? Mathf.Floor(y) * Stats.plBulletSpeed : Mathf.Ceil(y) * Stats.plBulletSpeed,
            0
        );

        
    }

    public void ExShoot()
    {
        lp.attack(Stats.exL, plBulletPrefabEX);
    }
}
