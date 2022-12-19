using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightEn : MonoBehaviour
{
    public float sCooldown;
    private float cooldown;
    public bool Shoot { get; set; }
    Animator animator;
    


    void Start()
    {
        Shoot = true;
        animator = gameObject.GetComponent<Animator>();
        cooldown = sCooldown;
    }
    private void Update()
    {
        cooldown -= Time.deltaTime;

        if (cooldown <= 0 && Shoot)
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    animator.SetBool("DarkLight1", true);
                    animator.SetBool("DarkLight2", false);
                    animator.SetBool("DarkLight3", false);
                    break;
                case 2:
                    animator.SetBool("DarkLight1", false);
                    animator.SetBool("DarkLight2", true);
                    animator.SetBool("DarkLight3", false);
                    break;
                case 3:
                    animator.SetBool("DarkLight1", false);
                    animator.SetBool("DarkLight2", false);
                    animator.SetBool("DarkLight3", true);
                    break;
            }

            cooldown = sCooldown;
        }
    }

    

}
